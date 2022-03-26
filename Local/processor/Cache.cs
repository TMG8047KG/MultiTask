using System;
using System.Runtime.InteropServices;

namespace MultiTaskBase.Local.processor
{
    public class Cache
    {
        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();

        //[DllImport("kernel32.dll")]
        //public static extern int GetCurrentProcessorNumber();

        [StructLayout(LayoutKind.Sequential, Pack = 4)]
        private struct GROUP_AFFINITY
        {
            public UIntPtr Mask;

            [MarshalAs(UnmanagedType.U2)]
            public ushort Group;

            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3, ArraySubType = UnmanagedType.U2)]
            public ushort[] Reserved;
        }

        [DllImport("kernel32", SetLastError = true)]
        private static extern Boolean SetThreadGroupAffinity(IntPtr hThread, ref GROUP_AFFINITY GroupAffinity, ref GROUP_AFFINITY PreviousGroupAffinity);

        [StructLayout(LayoutKind.Sequential)]
        public struct PROCESSORCORE
        {
            public byte Flags;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct NUMANODE
        {
            public uint NodeNumber;
        }

        public enum PROCESSOR_CACHE_TYPE
        {
            CacheUnified,
            CacheInstruction,
            CacheData,
            CacheTrace
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct CACHE_DESCRIPTOR
        {
            public byte Level;
            public byte Associativity;
            public ushort LineSize;
            public uint Size;
            public PROCESSOR_CACHE_TYPE Type;
        }

        [StructLayout(LayoutKind.Explicit)]
        public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION_UNION
        {
            [FieldOffset(0)]
            public PROCESSORCORE ProcessorCore;
            [FieldOffset(0)]
            public NUMANODE NumaNode;
            [FieldOffset(0)]
            public CACHE_DESCRIPTOR Cache;
            [FieldOffset(0)]
            private UInt64 Reserved1;
            [FieldOffset(8)]
            private UInt64 Reserved2;
        }

        public enum LOGICAL_PROCESSOR_RELATIONSHIP
        {
            RelationProcessorCore,
            RelationNumaNode,
            RelationCache,
            RelationProcessorPackage,
            RelationGroup,
            RelationAll = 0xffff
        }

        public struct SYSTEM_LOGICAL_PROCESSOR_INFORMATION
        {
#pragma warning disable 0649
            public UIntPtr ProcessorMask;
            public LOGICAL_PROCESSOR_RELATIONSHIP Relationship;
            public SYSTEM_LOGICAL_PROCESSOR_INFORMATION_UNION ProcessorInformation;
#pragma warning restore 0649
        }

        [DllImport(@"kernel32.dll", SetLastError = true)]
        public static extern bool GetLogicalProcessorInformation(IntPtr Buffer, ref uint ReturnLength);

        private const int ERROR_INSUFFICIENT_BUFFER = 122;

        private static SYSTEM_LOGICAL_PROCESSOR_INFORMATION[] _logicalProcessorInformation = null;

        public static SYSTEM_LOGICAL_PROCESSOR_INFORMATION[] LogicalProcessorInformation
        {
            get
            {
                if (_logicalProcessorInformation != null)
                    return _logicalProcessorInformation;

                uint ReturnLength = 0;

                GetLogicalProcessorInformation(IntPtr.Zero, ref ReturnLength);

                if (Marshal.GetLastWin32Error() == ERROR_INSUFFICIENT_BUFFER)
                {
                    IntPtr Ptr = Marshal.AllocHGlobal((int)ReturnLength);
                    try
                    {
                        if (GetLogicalProcessorInformation(Ptr, ref ReturnLength))
                        {
                            int size = Marshal.SizeOf(typeof(SYSTEM_LOGICAL_PROCESSOR_INFORMATION));
                            int len = (int)ReturnLength / size;
                            _logicalProcessorInformation = new SYSTEM_LOGICAL_PROCESSOR_INFORMATION[len];
                            IntPtr Item = Ptr;

                            for (int i = 0; i < len; i++)
                            {
                                _logicalProcessorInformation[i] = (SYSTEM_LOGICAL_PROCESSOR_INFORMATION)Marshal.PtrToStructure(Item, typeof(SYSTEM_LOGICAL_PROCESSOR_INFORMATION));
                                Item += size;
                            }

                            return _logicalProcessorInformation;
                        }
                    }
                    finally
                    {
                        Marshal.FreeHGlobal(Ptr);
                    }
                }
                return null;
            }
        }
        public static void GetPerCoreCacheSizes(out Int64 L1, out Int64 L2, out Int64 L3)
        {
            L1 = 0;
            L2 = 0;
            L3 = 0;

            var info = Cache.LogicalProcessorInformation;
            foreach (var entry in info)
            {
                if (entry.Relationship != Cache.LOGICAL_PROCESSOR_RELATIONSHIP.RelationCache)
                    continue;
                Int64 mask = (Int64)entry.ProcessorMask;
                if ((mask & (Int64)1) == 0)
                    continue;
                var cache = entry.ProcessorInformation.Cache;
                switch (cache.Level)
                {
                    case 1: L1 = L1 + cache.Size; break;
                    case 2: L2 = L2 + cache.Size; break;
                    case 3: L3 = L3 + cache.Size; break;
                    default:
                        break;
                }
            }
        }
    }
        
}

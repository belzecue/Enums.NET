﻿using System;
using System.Globalization;

namespace EnumsNET
{
	internal static class IntegralOperators<T>
	{
		internal static Func<T, T, bool> Equals;

		internal static Func<T, T, bool> GreaterThan;

		internal static Func<T, T, T> And;

		internal static Func<T, T, T> Or;

		internal static Func<T, T, T> Xor;

		internal static Func<T, bool> IsPowerOfTwo;

		internal static Func<long, T> FromInt64;

		internal static Func<ulong, T> FromUInt64;

		internal static Func<long, bool> Int64IsInValueRange;

		internal static Func<ulong, bool> UInt64IsInValueRange;

		internal static Func<T, sbyte> ToSByte;

		internal static Func<T, byte> ToByte;

		internal static Func<T, short> ToInt16;

		internal static Func<T, ushort> ToUInt16;

		internal static Func<T, int> ToInt32;

		internal static Func<T, uint> ToUInt32;

		internal static Func<T, long> ToInt64;

		internal static Func<T, ulong> ToUInt64;

		internal static Func<T, string, string> ToString;

		internal static TryParseDelegate<T> TryParse;

		internal static string HexFormatString;

		static IntegralOperators()
		{
			IntegralOperators.Populate(Type.GetTypeCode(typeof(T)));
		}
	}

	internal delegate bool TryParseDelegate<T>(string value, NumberStyles styles, IFormatProvider provider, out T result);

	internal static class IntegralOperators
	{
		internal static void Populate(TypeCode typeCode)
		{
			switch (typeCode)
			{
				case TypeCode.Int32:
					IntegralOperators<int>.Equals = (x, y) => x == y;
					IntegralOperators<int>.GreaterThan = (x, y) => x > y;
					IntegralOperators<int>.And = (x, y) => x & y;
					IntegralOperators<int>.Or = (x, y) => x | y;
					IntegralOperators<int>.Xor = (x, y) => x ^ y;
					IntegralOperators<int>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<int>.FromInt64 = x => (int)x;
					IntegralOperators<int>.FromUInt64 = x => (int)x;
					IntegralOperators<int>.Int64IsInValueRange = x => x >= int.MinValue && x <= int.MaxValue;
					IntegralOperators<int>.UInt64IsInValueRange = x => x <= int.MaxValue;
					IntegralOperators<int>.ToSByte = Convert.ToSByte;
					IntegralOperators<int>.ToByte = Convert.ToByte;
					IntegralOperators<int>.ToInt16 = Convert.ToInt16;
					IntegralOperators<int>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<int>.ToInt32 = Convert.ToInt32;
					IntegralOperators<int>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<int>.ToInt64 = Convert.ToInt64;
					IntegralOperators<int>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<int>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<int>.TryParse = int.TryParse;
					IntegralOperators<int>.HexFormatString = "X8";
					break;
				case TypeCode.UInt32:
					IntegralOperators<uint>.Equals = (x, y) => x == y;
					IntegralOperators<uint>.GreaterThan = (x, y) => x > y;
					IntegralOperators<uint>.And = (x, y) => x & y;
					IntegralOperators<uint>.Or = (x, y) => x | y;
					IntegralOperators<uint>.Xor = (x, y) => x ^ y;
					IntegralOperators<uint>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<uint>.FromInt64 = x => (uint)x;
					IntegralOperators<uint>.FromUInt64 = x => (uint)x;
					IntegralOperators<uint>.Int64IsInValueRange = x => x >= uint.MinValue && x <= uint.MaxValue;
					IntegralOperators<uint>.UInt64IsInValueRange = x => x <= uint.MaxValue;
					IntegralOperators<uint>.ToSByte = Convert.ToSByte;
					IntegralOperators<uint>.ToByte = Convert.ToByte;
					IntegralOperators<uint>.ToInt16 = Convert.ToInt16;
					IntegralOperators<uint>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<uint>.ToInt32 = Convert.ToInt32;
					IntegralOperators<uint>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<uint>.ToInt64 = Convert.ToInt64;
					IntegralOperators<uint>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<uint>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<uint>.TryParse = uint.TryParse;
					IntegralOperators<uint>.HexFormatString = "X8";
					break;
				case TypeCode.Int64:
					IntegralOperators<long>.Equals = (x, y) => x == y;
					IntegralOperators<long>.GreaterThan = (x, y) => x > y;
					IntegralOperators<long>.And = (x, y) => x & y;
					IntegralOperators<long>.Or = (x, y) => x | y;
					IntegralOperators<long>.Xor = (x, y) => x ^ y;
					IntegralOperators<long>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<long>.FromInt64 = x => x;
					IntegralOperators<long>.FromUInt64 = x => (long)x;
					IntegralOperators<long>.Int64IsInValueRange = x => true;
					IntegralOperators<long>.UInt64IsInValueRange = x => x <= long.MaxValue;
					IntegralOperators<long>.ToSByte = Convert.ToSByte;
					IntegralOperators<long>.ToByte = Convert.ToByte;
					IntegralOperators<long>.ToInt16 = Convert.ToInt16;
					IntegralOperators<long>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<long>.ToInt32 = Convert.ToInt32;
					IntegralOperators<long>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<long>.ToInt64 = Convert.ToInt64;
					IntegralOperators<long>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<long>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<long>.TryParse = long.TryParse;
					IntegralOperators<long>.HexFormatString = "X16";
					break;
				case TypeCode.UInt64:
					IntegralOperators<ulong>.Equals = (x, y) => x == y;
					IntegralOperators<ulong>.GreaterThan = (x, y) => x > y;
					IntegralOperators<ulong>.And = (x, y) => x & y;
					IntegralOperators<ulong>.Or = (x, y) => x | y;
					IntegralOperators<ulong>.Xor = (x, y) => x ^ y;
					IntegralOperators<ulong>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<ulong>.FromInt64 = x => (ulong)x;
					IntegralOperators<ulong>.FromUInt64 = x => x;
					IntegralOperators<ulong>.Int64IsInValueRange = x => x >= 0L;
					IntegralOperators<ulong>.UInt64IsInValueRange = x => true;
					IntegralOperators<ulong>.ToSByte = Convert.ToSByte;
					IntegralOperators<ulong>.ToByte = Convert.ToByte;
					IntegralOperators<ulong>.ToInt16 = Convert.ToInt16;
					IntegralOperators<ulong>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<ulong>.ToInt32 = Convert.ToInt32;
					IntegralOperators<ulong>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<ulong>.ToInt64 = Convert.ToInt64;
					IntegralOperators<ulong>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<ulong>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<ulong>.TryParse = ulong.TryParse;
					IntegralOperators<ulong>.HexFormatString = "X16";
					break;
				case TypeCode.SByte:
					IntegralOperators<sbyte>.Equals = (x, y) => x == y;
					IntegralOperators<sbyte>.GreaterThan = (x, y) => x > y;
					IntegralOperators<sbyte>.And = (x, y) => (sbyte)(x & y);
					IntegralOperators<sbyte>.Or = (x, y) => (sbyte)(x | y);
					IntegralOperators<sbyte>.Xor = (x, y) => (sbyte)(x ^ y);
					IntegralOperators<sbyte>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<sbyte>.FromInt64 = x => (sbyte)x;
					IntegralOperators<sbyte>.FromUInt64 = x => (sbyte)x;
					IntegralOperators<sbyte>.Int64IsInValueRange = x => x >= sbyte.MinValue && x <= sbyte.MaxValue;
					IntegralOperators<sbyte>.UInt64IsInValueRange = x => x <= (ulong)sbyte.MaxValue;
					IntegralOperators<sbyte>.ToSByte = Convert.ToSByte;
					IntegralOperators<sbyte>.ToByte = Convert.ToByte;
					IntegralOperators<sbyte>.ToInt16 = Convert.ToInt16;
					IntegralOperators<sbyte>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<sbyte>.ToInt32 = Convert.ToInt32;
					IntegralOperators<sbyte>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<sbyte>.ToInt64 = Convert.ToInt64;
					IntegralOperators<sbyte>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<sbyte>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<sbyte>.TryParse = sbyte.TryParse;
					IntegralOperators<sbyte>.HexFormatString = "X2";
					break;
				case TypeCode.Byte:
					IntegralOperators<byte>.Equals = (x, y) => x == y;
					IntegralOperators<byte>.GreaterThan = (x, y) => x > y;
					IntegralOperators<byte>.And = (x, y) => (byte)(x & y);
					IntegralOperators<byte>.Or = (x, y) => (byte)(x | y);
					IntegralOperators<byte>.Xor = (x, y) => (byte)(x ^ y);
					IntegralOperators<byte>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<byte>.FromInt64 = x => (byte)x;
					IntegralOperators<byte>.FromUInt64 = x => (byte)x;
					IntegralOperators<byte>.Int64IsInValueRange = x => x >= byte.MinValue && x <= byte.MaxValue;
					IntegralOperators<byte>.UInt64IsInValueRange = x => x <= byte.MaxValue;
					IntegralOperators<byte>.ToSByte = Convert.ToSByte;
					IntegralOperators<byte>.ToByte = Convert.ToByte;
					IntegralOperators<byte>.ToInt16 = Convert.ToInt16;
					IntegralOperators<byte>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<byte>.ToInt32 = Convert.ToInt32;
					IntegralOperators<byte>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<byte>.ToInt64 = Convert.ToInt64;
					IntegralOperators<byte>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<byte>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<byte>.TryParse = byte.TryParse;
					IntegralOperators<byte>.HexFormatString = "X2";
					break;
				case TypeCode.Int16:
					IntegralOperators<short>.Equals = (x, y) => x == y;
					IntegralOperators<short>.GreaterThan = (x, y) => x > y;
					IntegralOperators<short>.And = (x, y) => (short)(x & y);
					IntegralOperators<short>.Or = (x, y) => (short)(x | y);
					IntegralOperators<short>.Xor = (x, y) => (short)(x ^ y);
					IntegralOperators<short>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<short>.FromInt64 = x => (short)x;
					IntegralOperators<short>.FromUInt64 = x => (short)x;
					IntegralOperators<short>.Int64IsInValueRange = x => x >= short.MinValue && x <= short.MaxValue;
					IntegralOperators<short>.UInt64IsInValueRange = x => x <= (ulong)short.MaxValue;
					IntegralOperators<short>.ToSByte = Convert.ToSByte;
					IntegralOperators<short>.ToByte = Convert.ToByte;
					IntegralOperators<short>.ToInt16 = Convert.ToInt16;
					IntegralOperators<short>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<short>.ToInt32 = Convert.ToInt32;
					IntegralOperators<short>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<short>.ToInt64 = Convert.ToInt64;
					IntegralOperators<short>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<short>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<short>.TryParse = short.TryParse;
					IntegralOperators<short>.HexFormatString = "X4";
					break;
				case TypeCode.UInt16:
					IntegralOperators<ushort>.Equals = (x, y) => x == y;
					IntegralOperators<ushort>.GreaterThan = (x, y) => x > y;
					IntegralOperators<ushort>.And = (x, y) => (ushort)(x & y);
					IntegralOperators<ushort>.Or = (x, y) => (ushort)(x | y);
					IntegralOperators<ushort>.Xor = (x, y) => (ushort)(x ^ y);
					IntegralOperators<ushort>.IsPowerOfTwo = x => (x & (x - 1)) == 0;
					IntegralOperators<ushort>.FromInt64 = x => (ushort)x;
					IntegralOperators<ushort>.FromUInt64 = x => (ushort)x;
					IntegralOperators<ushort>.Int64IsInValueRange = x => x >= ushort.MinValue && x <= ushort.MaxValue;
					IntegralOperators<ushort>.UInt64IsInValueRange = x => x <= ushort.MaxValue;
					IntegralOperators<ushort>.ToSByte = Convert.ToSByte;
					IntegralOperators<ushort>.ToByte = Convert.ToByte;
					IntegralOperators<ushort>.ToInt16 = Convert.ToInt16;
					IntegralOperators<ushort>.ToUInt16 = Convert.ToUInt16;
					IntegralOperators<ushort>.ToInt32 = Convert.ToInt32;
					IntegralOperators<ushort>.ToUInt32 = Convert.ToUInt32;
					IntegralOperators<ushort>.ToInt64 = Convert.ToInt64;
					IntegralOperators<ushort>.ToUInt64 = Convert.ToUInt64;
					IntegralOperators<ushort>.ToString = (x, format) => x.ToString(format);
					IntegralOperators<ushort>.TryParse = ushort.TryParse;
					IntegralOperators<ushort>.HexFormatString = "X4";
					break;
			}
		}
	}
}
#pragma warning disable CS0414 // Field is assigned but its value is never used

namespace ConsoleApp1.objects;

public class DataTypes
{
    private bool boolean = true;
    private byte unsigned_8bit = 255;
    private sbyte signed_8bit = -128;
    private ushort unsigned_16bit = 65535;
    private short signed_16bit = -32768;
    private uint unsigned_32bit = 4294967295U;
    private int signed_32bit = -2147483648;
    private ulong unsigned_64bit = 18_446_744_073_709_551_615UL;
    private long signed_64bit = -9_223_372_036_854_775_808L;
    private float float_32 = 4.2f;
    private double float_64 = 4.2d;
    private decimal dec_128 = 0.1m;
    private char character = 'a';
    private string yea_string = "STRIIIIINg!!!";
    private object obj = new string("STR_obj");

    private static byte _a = 4;
    private static byte _b = (byte)(_a + 70);

    //Widening:
    /*
     * byte -> short -> int -> long -> decimal
     *int -> double
`   *short -> float -> double
    *char -> int
     */
}
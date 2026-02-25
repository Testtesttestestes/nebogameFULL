using System;
using System.Collections.Generic;
using Il2CppDummyDll;

// Token: 0x02000005 RID: 5
[Token(Token = "0x2000005")]
public class Amplitude
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x54D3", Offset = "0x54D3", VA = "0x54D3")]
	public static Amplitude getInstance()
	{
		return null;
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000006")]
	[Address(RVA = "0x54D4", Offset = "0x54D4", VA = "0x54D4")]
	public static Amplitude getInstance(string instanceName)
	{
		return null;
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000007 RID: 7 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x17000001")]
	public static Amplitude Instance
	{
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x54D5", Offset = "0x54D5", VA = "0x54D5")]
		get
		{
			return null;
		}
	}

	// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x4BAE", Offset = "0x4BAE", VA = "0x4BAE")]
	public Amplitude(string instanceName)
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x54D6", Offset = "0x54D6", VA = "0x54D6")]
	protected void Log(string message)
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	protected void Log<T>(string message, string property, IEnumerable<T> array)
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x54D7", Offset = "0x54D7", VA = "0x54D7")]
	public void init(string apiKey)
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x54D8", Offset = "0x54D8", VA = "0x54D8")]
	public void init(string apiKey, string userId)
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x54D9", Offset = "0x54D9", VA = "0x54D9")]
	public void setTrackingOptions(IDictionary<string, bool> trackingOptions)
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x54DA", Offset = "0x54DA", VA = "0x54DA")]
	public void logEvent(string evt)
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x54DB", Offset = "0x54DB", VA = "0x54DB")]
	public void logEvent(string evt, IDictionary<string, object> properties)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x54DC", Offset = "0x54DC", VA = "0x54DC")]
	public void logEvent(string evt, IDictionary<string, object> properties, bool outOfSession)
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x54DD", Offset = "0x54DD", VA = "0x54DD")]
	public void setOffline(bool offline)
	{
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x54DE", Offset = "0x54DE", VA = "0x54DE")]
	public void setUserId(string userId)
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x54DF", Offset = "0x54DF", VA = "0x54DF")]
	public void setUserProperties(IDictionary<string, object> properties)
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x54E0", Offset = "0x54E0", VA = "0x54E0")]
	public void setGroup(string groupType, string groupName)
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x54E1", Offset = "0x54E1", VA = "0x54E1")]
	public void setGroup(string groupType, string[] groupName)
	{
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000016")]
	[Address(RVA = "0x54E2", Offset = "0x54E2", VA = "0x54E2")]
	public void setOptOut(bool enabled)
	{
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000017")]
	[Address(RVA = "0x54E3", Offset = "0x54E3", VA = "0x54E3")]
	public void setMinTimeBetweenSessionsMillis(long minTimeBetweenSessionsMillis)
	{
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000018")]
	[Address(RVA = "0x54E4", Offset = "0x54E4", VA = "0x54E4")]
	public void setEventUploadPeriodSeconds(int eventUploadPeriodSeconds)
	{
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000019")]
	[Address(RVA = "0x54E5", Offset = "0x54E5", VA = "0x54E5")]
	public void setDeviceId(string deviceId)
	{
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001A")]
	[Address(RVA = "0x54E6", Offset = "0x54E6", VA = "0x54E6")]
	public void enableCoppaControl()
	{
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001B")]
	[Address(RVA = "0x54E7", Offset = "0x54E7", VA = "0x54E7")]
	public void disableCoppaControl()
	{
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001C")]
	[Address(RVA = "0x54E8", Offset = "0x54E8", VA = "0x54E8")]
	public void setServerUrl(string serverUrl)
	{
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001D")]
	[Address(RVA = "0x54E9", Offset = "0x54E9", VA = "0x54E9")]
	public void setUseDynamicConfig(bool useDynamicConfig)
	{
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001E")]
	[Address(RVA = "0x54EA", Offset = "0x54EA", VA = "0x54EA")]
	public void setServerZone(AmplitudeServerZone serverZone, bool updateServerUrl = true)
	{
	}

	// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600001F")]
	[Address(RVA = "0x54EB", Offset = "0x54EB", VA = "0x54EB")]
	[Obsolete("Please call setUserProperties instead", false)]
	public void setGlobalUserProperties(IDictionary<string, object> properties)
	{
	}

	// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000020")]
	[Address(RVA = "0x54EC", Offset = "0x54EC", VA = "0x54EC")]
	public void logRevenue(double amount)
	{
	}

	// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000021")]
	[Address(RVA = "0x54ED", Offset = "0x54ED", VA = "0x54ED")]
	public void logRevenue(string productId, int quantity, double price)
	{
	}

	// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000022")]
	[Address(RVA = "0x54EE", Offset = "0x54EE", VA = "0x54EE")]
	public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature)
	{
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000023")]
	[Address(RVA = "0x54EF", Offset = "0x54EF", VA = "0x54EF")]
	public void logRevenue(string productId, int quantity, double price, string receipt, string receiptSignature, string revenueType, IDictionary<string, object> eventProperties)
	{
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000024")]
	[Address(RVA = "0x54F0", Offset = "0x54F0", VA = "0x54F0")]
	public string getDeviceId()
	{
		return null;
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000025")]
	[Address(RVA = "0x54F1", Offset = "0x54F1", VA = "0x54F1")]
	public void regenerateDeviceId()
	{
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000026")]
	[Address(RVA = "0x54F2", Offset = "0x54F2", VA = "0x54F2")]
	public void useAdvertisingIdForDeviceId()
	{
	}

	// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000027")]
	[Address(RVA = "0x54F3", Offset = "0x54F3", VA = "0x54F3")]
	public void useAppSetIdForDeviceId()
	{
	}

	// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000028")]
	[Address(RVA = "0x54F4", Offset = "0x54F4", VA = "0x54F4")]
	public void trackSessionEvents(bool enabled)
	{
	}

	// Token: 0x06000029 RID: 41 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000029")]
	[Address(RVA = "0x54F5", Offset = "0x54F5", VA = "0x54F5")]
	public long getSessionId()
	{
		return 0L;
	}

	// Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002A")]
	[Address(RVA = "0x54F6", Offset = "0x54F6", VA = "0x54F6")]
	public void uploadEvents()
	{
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x54F7", Offset = "0x54F7", VA = "0x54F7")]
	public void clearUserProperties()
	{
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0x54F8", Offset = "0x54F8", VA = "0x54F8")]
	public void unsetUserProperty(string property)
	{
	}

	// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002D")]
	[Address(RVA = "0x54F9", Offset = "0x54F9", VA = "0x54F9")]
	public void setOnceUserProperty(string property, bool value)
	{
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002E")]
	[Address(RVA = "0x54FA", Offset = "0x54FA", VA = "0x54FA")]
	public void setOnceUserProperty(string property, double value)
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002F")]
	[Address(RVA = "0x54FB", Offset = "0x54FB", VA = "0x54FB")]
	public void setOnceUserProperty(string property, float value)
	{
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000030")]
	[Address(RVA = "0x54FC", Offset = "0x54FC", VA = "0x54FC")]
	public void setOnceUserProperty(string property, int value)
	{
	}

	// Token: 0x06000031 RID: 49 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000031")]
	[Address(RVA = "0x54FD", Offset = "0x54FD", VA = "0x54FD")]
	public void setOnceUserProperty(string property, long value)
	{
	}

	// Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000032")]
	[Address(RVA = "0x54FE", Offset = "0x54FE", VA = "0x54FE")]
	public void setOnceUserProperty(string property, string value)
	{
	}

	// Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000033")]
	[Address(RVA = "0x54FF", Offset = "0x54FF", VA = "0x54FF")]
	public void setOnceUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000034")]
	public void setOnceUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000035")]
	[Address(RVA = "0x5500", Offset = "0x5500", VA = "0x5500")]
	public void setOnceUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000036")]
	[Address(RVA = "0x5501", Offset = "0x5501", VA = "0x5501")]
	public void setOnceUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000037")]
	[Address(RVA = "0x5502", Offset = "0x5502", VA = "0x5502")]
	public void setOnceUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000038")]
	[Address(RVA = "0x5503", Offset = "0x5503", VA = "0x5503")]
	public void setOnceUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x5504", Offset = "0x5504", VA = "0x5504")]
	public void setOnceUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x5505", Offset = "0x5505", VA = "0x5505")]
	public void setOnceUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x5506", Offset = "0x5506", VA = "0x5506")]
	public void setUserProperty(string property, bool value)
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x5507", Offset = "0x5507", VA = "0x5507")]
	public void setUserProperty(string property, double value)
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x5508", Offset = "0x5508", VA = "0x5508")]
	public void setUserProperty(string property, float value)
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x5509", Offset = "0x5509", VA = "0x5509")]
	public void setUserProperty(string property, int value)
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x550A", Offset = "0x550A", VA = "0x550A")]
	public void setUserProperty(string property, long value)
	{
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000040")]
	[Address(RVA = "0x550B", Offset = "0x550B", VA = "0x550B")]
	public void setUserProperty(string property, string value)
	{
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000041")]
	[Address(RVA = "0x550C", Offset = "0x550C", VA = "0x550C")]
	public void setUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000042 RID: 66 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000042")]
	public void setUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000043 RID: 67 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000043")]
	[Address(RVA = "0x550D", Offset = "0x550D", VA = "0x550D")]
	public void setUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000044 RID: 68 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000044")]
	[Address(RVA = "0x550E", Offset = "0x550E", VA = "0x550E")]
	public void setUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000045 RID: 69 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000045")]
	[Address(RVA = "0x550F", Offset = "0x550F", VA = "0x550F")]
	public void setUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000046")]
	[Address(RVA = "0x5510", Offset = "0x5510", VA = "0x5510")]
	public void setUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000047")]
	[Address(RVA = "0x5511", Offset = "0x5511", VA = "0x5511")]
	public void setUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000048 RID: 72 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000048")]
	[Address(RVA = "0x5512", Offset = "0x5512", VA = "0x5512")]
	public void setUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000049")]
	[Address(RVA = "0x5513", Offset = "0x5513", VA = "0x5513")]
	public void addUserProperty(string property, double value)
	{
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x5514", Offset = "0x5514", VA = "0x5514")]
	public void addUserProperty(string property, float value)
	{
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x5515", Offset = "0x5515", VA = "0x5515")]
	public void addUserProperty(string property, int value)
	{
	}

	// Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x5516", Offset = "0x5516", VA = "0x5516")]
	public void addUserProperty(string property, long value)
	{
	}

	// Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004D")]
	[Address(RVA = "0x5517", Offset = "0x5517", VA = "0x5517")]
	public void addUserProperty(string property, string value)
	{
	}

	// Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004E")]
	[Address(RVA = "0x5518", Offset = "0x5518", VA = "0x5518")]
	public void addUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x0600004F RID: 79 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004F")]
	[Address(RVA = "0x5519", Offset = "0x5519", VA = "0x5519")]
	public void appendUserProperty(string property, bool value)
	{
	}

	// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000050")]
	[Address(RVA = "0x551A", Offset = "0x551A", VA = "0x551A")]
	public void appendUserProperty(string property, double value)
	{
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000051")]
	[Address(RVA = "0x551B", Offset = "0x551B", VA = "0x551B")]
	public void appendUserProperty(string property, float value)
	{
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000052")]
	[Address(RVA = "0x551C", Offset = "0x551C", VA = "0x551C")]
	public void appendUserProperty(string property, int value)
	{
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000053")]
	[Address(RVA = "0x551D", Offset = "0x551D", VA = "0x551D")]
	public void appendUserProperty(string property, long value)
	{
	}

	// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000054")]
	[Address(RVA = "0x551E", Offset = "0x551E", VA = "0x551E")]
	public void appendUserProperty(string property, string value)
	{
	}

	// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000055")]
	[Address(RVA = "0x551F", Offset = "0x551F", VA = "0x551F")]
	public void appendUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000056 RID: 86 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000056")]
	public void appendUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000057")]
	[Address(RVA = "0x5520", Offset = "0x5520", VA = "0x5520")]
	public void appendUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x5521", Offset = "0x5521", VA = "0x5521")]
	public void appendUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000059")]
	[Address(RVA = "0x5522", Offset = "0x5522", VA = "0x5522")]
	public void appendUserProperty(string property, float[] array)
	{
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005A")]
	[Address(RVA = "0x5523", Offset = "0x5523", VA = "0x5523")]
	public void appendUserProperty(string property, int[] array)
	{
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x5524", Offset = "0x5524", VA = "0x5524")]
	public void appendUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005C")]
	[Address(RVA = "0x5525", Offset = "0x5525", VA = "0x5525")]
	public void appendUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x5526", Offset = "0x5526", VA = "0x5526")]
	public void prependUserProperty(string property, bool value)
	{
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005E")]
	[Address(RVA = "0x5527", Offset = "0x5527", VA = "0x5527")]
	public void prependUserProperty(string property, double value)
	{
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600005F")]
	[Address(RVA = "0x5528", Offset = "0x5528", VA = "0x5528")]
	public void prependUserProperty(string property, float value)
	{
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000060")]
	[Address(RVA = "0x5529", Offset = "0x5529", VA = "0x5529")]
	public void prependUserProperty(string property, int value)
	{
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000061")]
	[Address(RVA = "0x552A", Offset = "0x552A", VA = "0x552A")]
	public void prependUserProperty(string property, long value)
	{
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000062")]
	[Address(RVA = "0x552B", Offset = "0x552B", VA = "0x552B")]
	public void prependUserProperty(string property, string value)
	{
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000063")]
	[Address(RVA = "0x552C", Offset = "0x552C", VA = "0x552C")]
	public void prependUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000064")]
	public void prependUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000065")]
	[Address(RVA = "0x552D", Offset = "0x552D", VA = "0x552D")]
	public void prependUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000066")]
	[Address(RVA = "0x552E", Offset = "0x552E", VA = "0x552E")]
	public void prependUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000067")]
	[Address(RVA = "0x552F", Offset = "0x552F", VA = "0x552F")]
	public void prependUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000068")]
	[Address(RVA = "0x5530", Offset = "0x5530", VA = "0x5530")]
	public void prependUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000069")]
	[Address(RVA = "0x5531", Offset = "0x5531", VA = "0x5531")]
	public void prependUserProperty(string property, long[] array)
	{
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006A")]
	[Address(RVA = "0x5532", Offset = "0x5532", VA = "0x5532")]
	public void prependUserProperty(string property, string[] array)
	{
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006B")]
	[Address(RVA = "0x5533", Offset = "0x5533", VA = "0x5533")]
	public void preInsertUserProperty(string property, bool value)
	{
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006C")]
	[Address(RVA = "0x5534", Offset = "0x5534", VA = "0x5534")]
	public void preInsertUserProperty(string property, double value)
	{
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006D")]
	[Address(RVA = "0x5535", Offset = "0x5535", VA = "0x5535")]
	public void preInsertUserProperty(string property, float value)
	{
	}

	// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x5536", Offset = "0x5536", VA = "0x5536")]
	public void preInsertUserProperty(string property, int value)
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x5537", Offset = "0x5537", VA = "0x5537")]
	public void preInsertUserProperty(string property, long value)
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x5538", Offset = "0x5538", VA = "0x5538")]
	public void preInsertUserProperty(string property, string value)
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x5539", Offset = "0x5539", VA = "0x5539")]
	public void preInsertUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000072")]
	public void preInsertUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000073")]
	[Address(RVA = "0x553A", Offset = "0x553A", VA = "0x553A")]
	public void preInsertUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000074")]
	[Address(RVA = "0x553B", Offset = "0x553B", VA = "0x553B")]
	public void preInsertUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000075 RID: 117 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000075")]
	[Address(RVA = "0x553C", Offset = "0x553C", VA = "0x553C")]
	public void preInsertUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000076 RID: 118 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000076")]
	[Address(RVA = "0x553D", Offset = "0x553D", VA = "0x553D")]
	public void preInsertUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000077")]
	[Address(RVA = "0x553E", Offset = "0x553E", VA = "0x553E")]
	public void preInsertUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000078 RID: 120 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000078")]
	[Address(RVA = "0x553F", Offset = "0x553F", VA = "0x553F")]
	public void preInsertUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x5540", Offset = "0x5540", VA = "0x5540")]
	public void postInsertUserProperty(string property, bool value)
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x5541", Offset = "0x5541", VA = "0x5541")]
	public void postInsertUserProperty(string property, double value)
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x5542", Offset = "0x5542", VA = "0x5542")]
	public void postInsertUserProperty(string property, float value)
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x5543", Offset = "0x5543", VA = "0x5543")]
	public void postInsertUserProperty(string property, int value)
	{
	}

	// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x5544", Offset = "0x5544", VA = "0x5544")]
	public void postInsertUserProperty(string property, long value)
	{
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x5545", Offset = "0x5545", VA = "0x5545")]
	public void postInsertUserProperty(string property, string value)
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x5546", Offset = "0x5546", VA = "0x5546")]
	public void postInsertUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000080")]
	public void postInsertUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x5547", Offset = "0x5547", VA = "0x5547")]
	public void postInsertUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x5548", Offset = "0x5548", VA = "0x5548")]
	public void postInsertUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x5549", Offset = "0x5549", VA = "0x5549")]
	public void postInsertUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x554A", Offset = "0x554A", VA = "0x554A")]
	public void postInsertUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x554B", Offset = "0x554B", VA = "0x554B")]
	public void postInsertUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x554C", Offset = "0x554C", VA = "0x554C")]
	public void postInsertUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x554D", Offset = "0x554D", VA = "0x554D")]
	public void removeUserProperty(string property, bool value)
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x554E", Offset = "0x554E", VA = "0x554E")]
	public void removeUserProperty(string property, double value)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x554F", Offset = "0x554F", VA = "0x554F")]
	public void removeUserProperty(string property, float value)
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x5550", Offset = "0x5550", VA = "0x5550")]
	public void removeUserProperty(string property, int value)
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x5551", Offset = "0x5551", VA = "0x5551")]
	public void removeUserProperty(string property, long value)
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x5552", Offset = "0x5552", VA = "0x5552")]
	public void removeUserProperty(string property, string value)
	{
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008D")]
	[Address(RVA = "0x5553", Offset = "0x5553", VA = "0x5553")]
	public void removeUserProperty(string property, IDictionary<string, object> values)
	{
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008E")]
	public void removeUserProperty<T>(string property, IList<T> values)
	{
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600008F")]
	[Address(RVA = "0x5554", Offset = "0x5554", VA = "0x5554")]
	public void removeUserProperty(string property, bool[] array)
	{
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000090")]
	[Address(RVA = "0x5555", Offset = "0x5555", VA = "0x5555")]
	public void removeUserProperty(string property, double[] array)
	{
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000091")]
	[Address(RVA = "0x5556", Offset = "0x5556", VA = "0x5556")]
	public void removeUserProperty(string property, float[] array)
	{
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000092")]
	[Address(RVA = "0x5557", Offset = "0x5557", VA = "0x5557")]
	public void removeUserProperty(string property, int[] array)
	{
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000093")]
	[Address(RVA = "0x5558", Offset = "0x5558", VA = "0x5558")]
	public void removeUserProperty(string property, long[] array)
	{
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000094")]
	[Address(RVA = "0x5559", Offset = "0x5559", VA = "0x5559")]
	public void removeUserProperty(string property, string[] array)
	{
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000095")]
	[Address(RVA = "0x555A", Offset = "0x555A", VA = "0x555A")]
	private void setLibraryName(string libraryName)
	{
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000096")]
	[Address(RVA = "0x555B", Offset = "0x555B", VA = "0x555B")]
	private void setLibraryVersion(string libraryVersion)
	{
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000097")]
	[Address(RVA = "0x555C", Offset = "0x555C", VA = "0x555C")]
	public void startSession()
	{
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000098")]
	[Address(RVA = "0x555D", Offset = "0x555D", VA = "0x555D")]
	public void endSession()
	{
	}

	// Token: 0x04000003 RID: 3
	[Token(Token = "0x4000003")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string UnityLibraryName;

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x4")]
	private static readonly string UnityLibraryVersion;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Amplitude> instances;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0xC")]
	private static readonly object instanceLock;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x8")]
	public bool logging;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0xC")]
	private string instanceName;
}

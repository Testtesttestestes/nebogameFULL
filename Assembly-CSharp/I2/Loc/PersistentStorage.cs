using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001350 RID: 4944
	[Token(Token = "0x2001350")]
	public static class PersistentStorage
	{
		// Token: 0x06007568 RID: 30056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007568")]
		[Address(RVA = "0x3601", Offset = "0x3601", VA = "0x3601")]
		public static void SetSetting_String(string key, string value)
		{
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007569")]
		[Address(RVA = "0xBEFC", Offset = "0xBEFC", VA = "0xBEFC")]
		public static string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756A")]
		[Address(RVA = "0xBEFD", Offset = "0xBEFD", VA = "0xBEFD")]
		public static void DeleteSetting(string key)
		{
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x000151C8 File Offset: 0x000133C8
		[Token(Token = "0x600756B")]
		[Address(RVA = "0xBEFE", Offset = "0xBEFE", VA = "0xBEFE")]
		public static bool HasSetting(string key)
		{
			return default(bool);
		}

		// Token: 0x0600756C RID: 30060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600756C")]
		[Address(RVA = "0x3602", Offset = "0x3602", VA = "0x3602")]
		public static void ForceSaveSettings()
		{
		}

		// Token: 0x0600756D RID: 30061 RVA: 0x000151E0 File Offset: 0x000133E0
		[Token(Token = "0x600756D")]
		[Address(RVA = "0xBEFF", Offset = "0xBEFF", VA = "0xBEFF")]
		public static bool CanAccessFiles()
		{
			return default(bool);
		}

		// Token: 0x0600756E RID: 30062 RVA: 0x000151F8 File Offset: 0x000133F8
		[Token(Token = "0x600756E")]
		[Address(RVA = "0x3600", Offset = "0x3600", VA = "0x3600")]
		public static bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x0600756F RID: 30063 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600756F")]
		[Address(RVA = "0xBF00", Offset = "0xBF00", VA = "0xBF00")]
		public static string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		// Token: 0x06007570 RID: 30064 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x6007570")]
		[Address(RVA = "0xBF01", Offset = "0xBF01", VA = "0xBF01")]
		public static bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x06007571 RID: 30065 RVA: 0x00015228 File Offset: 0x00013428
		[Token(Token = "0x6007571")]
		[Address(RVA = "0xBF02", Offset = "0xBF02", VA = "0xBF02")]
		public static bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x04003D57 RID: 15703
		[Token(Token = "0x4003D57")]
		[FieldOffset(Offset = "0x0")]
		private static I2CustomPersistentStorage mStorage;

		// Token: 0x02001351 RID: 4945
		[Token(Token = "0x2001351")]
		public enum eFileType
		{
			// Token: 0x04003D59 RID: 15705
			[Token(Token = "0x4003D59")]
			Raw,
			// Token: 0x04003D5A RID: 15706
			[Token(Token = "0x4003D5A")]
			Persistent,
			// Token: 0x04003D5B RID: 15707
			[Token(Token = "0x4003D5B")]
			Temporal,
			// Token: 0x04003D5C RID: 15708
			[Token(Token = "0x4003D5C")]
			Streaming
		}
	}
}

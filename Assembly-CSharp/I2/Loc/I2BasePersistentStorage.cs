using System;
using Il2CppDummyDll;

namespace I2.Loc
{
	// Token: 0x02001352 RID: 4946
	[Token(Token = "0x2001352")]
	public abstract class I2BasePersistentStorage
	{
		// Token: 0x06007572 RID: 30066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007572")]
		[Address(RVA = "0xBF03", Offset = "0xBF03", VA = "0xBF03", Slot = "4")]
		public virtual void SetSetting_String(string key, string value)
		{
		}

		// Token: 0x06007573 RID: 30067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007573")]
		[Address(RVA = "0xBF04", Offset = "0xBF04", VA = "0xBF04", Slot = "5")]
		public virtual string GetSetting_String(string key, string defaultValue)
		{
			return null;
		}

		// Token: 0x06007574 RID: 30068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007574")]
		[Address(RVA = "0xBF05", Offset = "0xBF05", VA = "0xBF05", Slot = "6")]
		public virtual void DeleteSetting(string key)
		{
		}

		// Token: 0x06007575 RID: 30069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007575")]
		[Address(RVA = "0xBF06", Offset = "0xBF06", VA = "0xBF06", Slot = "7")]
		public virtual void ForceSaveSettings()
		{
		}

		// Token: 0x06007576 RID: 30070 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x6007576")]
		[Address(RVA = "0xBF07", Offset = "0xBF07", VA = "0xBF07", Slot = "8")]
		public virtual bool HasSetting(string key)
		{
			return default(bool);
		}

		// Token: 0x06007577 RID: 30071 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x6007577")]
		[Address(RVA = "0xBF08", Offset = "0xBF08", VA = "0xBF08", Slot = "9")]
		public virtual bool CanAccessFiles()
		{
			return default(bool);
		}

		// Token: 0x06007578 RID: 30072 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007578")]
		[Address(RVA = "0x1ED9", Offset = "0x1ED9", VA = "0x1ED9")]
		private string UpdateFilename(PersistentStorage.eFileType fileType, string fileName)
		{
			return null;
		}

		// Token: 0x06007579 RID: 30073 RVA: 0x00015270 File Offset: 0x00013470
		[Token(Token = "0x6007579")]
		[Address(RVA = "0xBF09", Offset = "0xBF09", VA = "0xBF09", Slot = "10")]
		public virtual bool SaveFile(PersistentStorage.eFileType fileType, string fileName, string data, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x0600757A RID: 30074 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600757A")]
		[Address(RVA = "0xBF0A", Offset = "0xBF0A", VA = "0xBF0A", Slot = "11")]
		public virtual string LoadFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return null;
		}

		// Token: 0x0600757B RID: 30075 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x600757B")]
		[Address(RVA = "0xBF0B", Offset = "0xBF0B", VA = "0xBF0B", Slot = "12")]
		public virtual bool DeleteFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x0600757C RID: 30076 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x600757C")]
		[Address(RVA = "0xBF0C", Offset = "0xBF0C", VA = "0xBF0C", Slot = "13")]
		public virtual bool HasFile(PersistentStorage.eFileType fileType, string fileName, bool logExceptions = true)
		{
			return default(bool);
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600757D")]
		[Address(RVA = "0xBF0D", Offset = "0xBF0D", VA = "0xBF0D")]
		protected I2BasePersistentStorage()
		{
		}
	}
}

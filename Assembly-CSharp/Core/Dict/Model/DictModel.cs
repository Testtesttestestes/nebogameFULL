using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Files;
using Core.Gameplay;
using Core.Gameplay.Managers.Configuration;
using Core.Log.Files;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Core.Dict.Model
{
	// Token: 0x02001096 RID: 4246
	[Token(Token = "0x2001096")]
	public class DictModel : AbstractModel
	{
		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x060062C3 RID: 25283 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C4 RID: 25284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AB")]
		public IAuthDataProvider AuthDataProvider
		{
			[Token(Token = "0x60062C3")]
			[Address(RVA = "0xAEE3", Offset = "0xAEE3", VA = "0xAEE3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C4")]
			[Address(RVA = "0xAEE4", Offset = "0xAEE4", VA = "0xAEE4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x060062C5 RID: 25285 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C6 RID: 25286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AC")]
		public IPlatformConfigurationProvider ConfigurationProvider
		{
			[Token(Token = "0x60062C5")]
			[Address(RVA = "0xAEE5", Offset = "0xAEE5", VA = "0xAEE5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C6")]
			[Address(RVA = "0xAEE6", Offset = "0xAEE6", VA = "0xAEE6")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x060062C7 RID: 25287 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062C8 RID: 25288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AD")]
		public Dictionaries RawData
		{
			[Token(Token = "0x60062C7")]
			[Address(RVA = "0xAEE7", Offset = "0xAEE7", VA = "0xAEE7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062C8")]
			[Address(RVA = "0xAEE8", Offset = "0xAEE8", VA = "0xAEE8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x060062C9 RID: 25289 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062CA RID: 25290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013AE")]
		public Dictionary<string, AssetDic> AssetsHash
		{
			[Token(Token = "0x60062C9")]
			[Address(RVA = "0xAEE9", Offset = "0xAEE9", VA = "0xAEE9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062CA")]
			[Address(RVA = "0xAEEA", Offset = "0xAEEA", VA = "0xAEEA")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060062CB RID: 25291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CB")]
		[Address(RVA = "0xAEEB", Offset = "0xAEEB", VA = "0xAEEB", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060062CC RID: 25292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CC")]
		[Address(RVA = "0xAEEC", Offset = "0xAEEC", VA = "0xAEEC")]
		public DictModel(IFileManager fileManager, IAuthDataProvider authDataProvider, IPlatformConfigurationProvider configurationProvider, FileDownloadLogger fileDownloadLogger, UserData user)
		{
		}

		// Token: 0x060062CD RID: 25293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60062CD")]
		[Address(RVA = "0xAEED", Offset = "0xAEED", VA = "0xAEED")]
		public void SetData(Dictionaries rawData, Dictionary<string, AssetDic> assetsHash)
		{
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x060062CE RID: 25294 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170013AF")]
		public string DownloadPath
		{
			[Token(Token = "0x60062CE")]
			[Address(RVA = "0x36DB", Offset = "0x36DB", VA = "0x36DB")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x060062CF RID: 25295 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060062D0 RID: 25296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013B0")]
		public string CurrentDownloadPath
		{
			[Token(Token = "0x60062CF")]
			[Address(RVA = "0xAEEE", Offset = "0xAEEE", VA = "0xAEEE")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60062D0")]
			[Address(RVA = "0xAEEF", Offset = "0xAEEF", VA = "0xAEEF")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x04003508 RID: 13576
		[Token(Token = "0x4003508")]
		[FieldOffset(Offset = "0x1C")]
		public FileDownloadLogger FileDownloadLogger;

		// Token: 0x04003509 RID: 13577
		[Token(Token = "0x4003509")]
		[FieldOffset(Offset = "0x20")]
		public readonly IFileManager FileManager;
	}
}

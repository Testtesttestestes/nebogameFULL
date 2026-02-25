using System;
using System.Runtime.CompilerServices;
using Core.Files;
using Core.Log.Files;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x02001251 RID: 4689
	[Token(Token = "0x2001251")]
	public class FilesAppManager : IAppManager, IBaseManager, IFileManager
	{
		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016B2")]
		public string Name
		{
			[Token(Token = "0x6006F22")]
			[Address(RVA = "0xB99D", Offset = "0xB99D", VA = "0xB99D", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002EB RID: 747
		// (add) Token: 0x06006F23 RID: 28451 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F24 RID: 28452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EB")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F23")]
			[Address(RVA = "0xB99E", Offset = "0xB99E", VA = "0xB99E", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F24")]
			[Address(RVA = "0xB99F", Offset = "0xB99F", VA = "0xB99F", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002EC RID: 748
		// (add) Token: 0x06006F25 RID: 28453 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F26 RID: 28454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EC")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F25")]
			[Address(RVA = "0xB9A0", Offset = "0xB9A0", VA = "0xB9A0", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F26")]
			[Address(RVA = "0xB9A1", Offset = "0xB9A1", VA = "0xB9A1", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06006F27 RID: 28455 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F28 RID: 28456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016B3")]
		public IApp Application
		{
			[Token(Token = "0x6006F27")]
			[Address(RVA = "0xB9A2", Offset = "0xB9A2", VA = "0xB9A2")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F28")]
			[Address(RVA = "0xB9A3", Offset = "0xB9A3", VA = "0xB9A3")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F29")]
		[Address(RVA = "0xB9A4", Offset = "0xB9A4", VA = "0xB9A4")]
		public FilesAppManager(IApp app)
		{
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2A")]
		[Address(RVA = "0xB9A5", Offset = "0xB9A5", VA = "0xB9A5", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2B")]
		[Address(RVA = "0xB9A6", Offset = "0xB9A6", VA = "0xB9A6", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0xB9A7", Offset = "0xB9A7", VA = "0xB9A7", Slot = "11")]
		public void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback)
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F2D")]
		[Address(RVA = "0xB9A8", Offset = "0xB9A8", VA = "0xB9A8", Slot = "12")]
		public void Load(string baseUri, string path, bool cacheOnDevice, Action<IFileContent> callback, FileDownloadLogger fileDownloadLogger)
		{
		}

		// Token: 0x04003A14 RID: 14868
		[Token(Token = "0x4003A14")]
		[FieldOffset(Offset = "0x10")]
		private IFileManager _fileManagerImpl;
	}
}

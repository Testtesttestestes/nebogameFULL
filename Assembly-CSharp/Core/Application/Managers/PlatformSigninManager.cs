using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Application.Managers
{
	// Token: 0x0200125A RID: 4698
	[Token(Token = "0x200125A")]
	public class PlatformSigninManager : IAppManager, IBaseManager
	{
		// Token: 0x170016BD RID: 5821
		// (get) Token: 0x06006F5E RID: 28510 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F5F RID: 28511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BD")]
		public IApp Application
		{
			[Token(Token = "0x6006F5E")]
			[Address(RVA = "0xB9C8", Offset = "0xB9C8", VA = "0xB9C8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F5F")]
			[Address(RVA = "0xB9C9", Offset = "0xB9C9", VA = "0xB9C9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06006F60 RID: 28512 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006F61 RID: 28513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016BE")]
		public IPlatformSigninProvider CurrentProvider
		{
			[Token(Token = "0x6006F60")]
			[Address(RVA = "0xB9CA", Offset = "0xB9CA", VA = "0xB9CA")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F61")]
			[Address(RVA = "0xB9CB", Offset = "0xB9CB", VA = "0xB9CB")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016BF")]
		public IPlatformSigninProvider TargetProvider
		{
			[Token(Token = "0x6006F62")]
			[Address(RVA = "0xB9CC", Offset = "0xB9CC", VA = "0xB9CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002EF RID: 751
		// (add) Token: 0x06006F63 RID: 28515 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F64 RID: 28516 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002EF")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006F63")]
			[Address(RVA = "0xB9CD", Offset = "0xB9CD", VA = "0xB9CD", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F64")]
			[Address(RVA = "0xB9CE", Offset = "0xB9CE", VA = "0xB9CE", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002F0 RID: 752
		// (add) Token: 0x06006F65 RID: 28517 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006F66 RID: 28518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002F0")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006F65")]
			[Address(RVA = "0xB9CF", Offset = "0xB9CF", VA = "0xB9CF", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006F66")]
			[Address(RVA = "0xB9D0", Offset = "0xB9D0", VA = "0xB9D0", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006F67 RID: 28519 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F67")]
		[Address(RVA = "0xB9D1", Offset = "0xB9D1", VA = "0xB9D1")]
		public PlatformSigninManager(IApp application)
		{
		}

		// Token: 0x06006F68 RID: 28520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F68")]
		[Address(RVA = "0xB9D2", Offset = "0xB9D2", VA = "0xB9D2", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06006F69 RID: 28521 RVA: 0x00014490 File Offset: 0x00012690
		[Token(Token = "0x170016C0")]
		public bool IsTargetSignin
		{
			[Token(Token = "0x6006F69")]
			[Address(RVA = "0x4889", Offset = "0x4889", VA = "0x4889")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006F6A RID: 28522 RVA: 0x000144A8 File Offset: 0x000126A8
		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0xB9D3", Offset = "0xB9D3", VA = "0xB9D3")]
		private UniTask<IPlatformSigninProvider> TrySignin(IPlatformSigninProvider provider)
		{
			return default(UniTask<IPlatformSigninProvider>);
		}

		// Token: 0x06006F6B RID: 28523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0xB9D4", Offset = "0xB9D4", VA = "0xB9D4")]
		private void CompleteSignin(IPlatformSigninProvider provider)
		{
		}

		// Token: 0x06006F6C RID: 28524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0xB9D5", Offset = "0xB9D5", VA = "0xB9D5")]
		public void SigninToTargetProvider(PlatformSigninProviderCallback callback)
		{
		}

		// Token: 0x06006F6D RID: 28525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0xB9D6", Offset = "0xB9D6", VA = "0xB9D6")]
		public void Commit(SigninRecord record)
		{
		}

		// Token: 0x06006F6E RID: 28526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0xB9D7", Offset = "0xB9D7", VA = "0xB9D7")]
		public void ResetToDefaultProvider()
		{
		}

		// Token: 0x06006F6F RID: 28527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0xB9D8", Offset = "0xB9D8", VA = "0xB9D8")]
		private void HandleDefaultSigninComplete(IPlatformSigninProvider provider)
		{
		}

		// Token: 0x06006F70 RID: 28528 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x226A", Offset = "0x226A", VA = "0x226A")]
		private void HandleTargetSigninComplete(IPlatformSigninProvider provider)
		{
		}

		// Token: 0x06006F71 RID: 28529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F71")]
		[Address(RVA = "0xB9D9", Offset = "0xB9D9", VA = "0xB9D9", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170016C1")]
		public string Name
		{
			[Token(Token = "0x6006F72")]
			[Address(RVA = "0xB9DA", Offset = "0xB9DA", VA = "0xB9DA", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003A28 RID: 14888
		[Token(Token = "0x4003A28")]
		[FieldOffset(Offset = "0x10")]
		private IPlatformSigninProvider _targetProvider;

		// Token: 0x04003A29 RID: 14889
		[Token(Token = "0x4003A29")]
		[FieldOffset(Offset = "0x14")]
		private IPlatformSigninProvider _defaultProvider;

		// Token: 0x04003A2C RID: 14892
		[Token(Token = "0x4003A2C")]
		[FieldOffset(Offset = "0x20")]
		private PlatformSigninProviderCallback _callbackForTry;
	}
}

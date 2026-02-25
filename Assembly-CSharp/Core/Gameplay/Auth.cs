using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Application.Managers;
using Core.Gameplay.Managers;
using Il2CppDummyDll;
using Protocol.Auth2;

namespace Core.Gameplay
{
	// Token: 0x02001118 RID: 4376
	[Token(Token = "0x2001118")]
	public class Auth : IAuth, IDisposable
	{
		// Token: 0x06006686 RID: 26246 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006686")]
		[Address(RVA = "0xB20A", Offset = "0xB20A", VA = "0xB20A", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006687")]
		[Address(RVA = "0xB20B", Offset = "0xB20B", VA = "0xB20B", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006688")]
		[Address(RVA = "0xB20C", Offset = "0xB20C", VA = "0xB20C")]
		public Auth(IApp app)
		{
		}

		// Token: 0x170014DF RID: 5343
		// (get) Token: 0x06006689 RID: 26249 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600668A RID: 26250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014DF")]
		public LoggedManager LoggedManager
		{
			[Token(Token = "0x6006689")]
			[Address(RVA = "0xB20D", Offset = "0xB20D", VA = "0xB20D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600668A")]
			[Address(RVA = "0xB20E", Offset = "0xB20E", VA = "0xB20E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170014E0 RID: 5344
		// (get) Token: 0x0600668B RID: 26251 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600668C RID: 26252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E0")]
		public IApp Application
		{
			[Token(Token = "0x600668B")]
			[Address(RVA = "0xB20F", Offset = "0xB20F", VA = "0xB20F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600668C")]
			[Address(RVA = "0xB210", Offset = "0xB210", VA = "0xB210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600668D RID: 26253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668D")]
		[Address(RVA = "0xB211", Offset = "0xB211", VA = "0xB211")]
		private void AuthManagerOnRegisterErrorEvent(RegisterCmd.Types.Result result, SigninRecord signinRecord)
		{
		}

		// Token: 0x0600668E RID: 26254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668E")]
		[Address(RVA = "0xB212", Offset = "0xB212", VA = "0xB212")]
		private void AuthManagerOnRegisterSuccessEvent(IAuthDataProvider provider)
		{
		}

		// Token: 0x0600668F RID: 26255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600668F")]
		[Address(RVA = "0xB213", Offset = "0xB213", VA = "0xB213")]
		private void AuthManagerOnLoginSuccessEvent(IAuthDataProvider provider)
		{
		}

		// Token: 0x06006690 RID: 26256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006690")]
		[Address(RVA = "0xB214", Offset = "0xB214", VA = "0xB214")]
		private void AuthManagerOnLoginErrorEvent(LoginCmd.Types.Result loginResult, SigninRecord signinRecord)
		{
		}

		// Token: 0x06006691 RID: 26257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006691")]
		[Address(RVA = "0xB215", Offset = "0xB215", VA = "0xB215")]
		private void AuthManagerOnUserIdChangedEvent(ulong userId)
		{
		}

		// Token: 0x06006692 RID: 26258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006692")]
		[Address(RVA = "0xB216", Offset = "0xB216", VA = "0xB216")]
		private void CreateGameManagers()
		{
		}

		// Token: 0x06006693 RID: 26259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006693")]
		[Address(RVA = "0xB217", Offset = "0xB217", VA = "0xB217")]
		private void HandleManagersQueue()
		{
		}

		// Token: 0x06006694 RID: 26260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006694")]
		[Address(RVA = "0xB218", Offset = "0xB218", VA = "0xB218")]
		private void ManagerInitComplete(IBaseManager manager)
		{
		}

		// Token: 0x06006695 RID: 26261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006695")]
		[Address(RVA = "0xB219", Offset = "0xB219", VA = "0xB219")]
		private void InitCompleted()
		{
		}

		// Token: 0x06006696 RID: 26262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006696")]
		[Address(RVA = "0xB21A", Offset = "0xB21A", VA = "0xB21A")]
		private void HandleDeinitManagersQueue()
		{
		}

		// Token: 0x06006697 RID: 26263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006697")]
		[Address(RVA = "0xB21B", Offset = "0xB21B", VA = "0xB21B")]
		private void ManagerDeinitComplete(IBaseManager manager)
		{
		}

		// Token: 0x06006698 RID: 26264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006698")]
		[Address(RVA = "0xB21C", Offset = "0xB21C", VA = "0xB21C")]
		private void DeinitCompleted()
		{
		}

		// Token: 0x040036D1 RID: 14033
		[Token(Token = "0x40036D1")]
		[FieldOffset(Offset = "0x0")]
		private static int _instanceCount;

		// Token: 0x040036D2 RID: 14034
		[Token(Token = "0x40036D2")]
		[FieldOffset(Offset = "0x8")]
		public readonly int InstanceIndex;

		// Token: 0x040036D3 RID: 14035
		[Token(Token = "0x40036D3")]
		[FieldOffset(Offset = "0xC")]
		private List<IBaseManager> _managers;

		// Token: 0x040036D4 RID: 14036
		[Token(Token = "0x40036D4")]
		[FieldOffset(Offset = "0x10")]
		private int _currentIndex;
	}
}

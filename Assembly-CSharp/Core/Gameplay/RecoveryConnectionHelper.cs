using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers;
using Core.Application.Managers.Connection;
using Core.Gameplay.Managers;
using Core.Gameplay.Managers.Location;
using Google.Protobuf;
using Il2CppDummyDll;
using JetBrains.Annotations;
using Utils;

namespace Core.Gameplay
{
	// Token: 0x0200111E RID: 4382
	[Token(Token = "0x200111E")]
	public class RecoveryConnectionHelper : IRecoveryConnection, IDisposable
	{
		// Token: 0x170014E2 RID: 5346
		// (get) Token: 0x060066A2 RID: 26274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A3 RID: 26275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E2")]
		[CanBeNull]
		public ILoginProvider AuthLogin
		{
			[Token(Token = "0x60066A2")]
			[Address(RVA = "0xB223", Offset = "0xB223", VA = "0xB223", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A3")]
			[Address(RVA = "0xB224", Offset = "0xB224", VA = "0xB224", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E3 RID: 5347
		// (get) Token: 0x060066A4 RID: 26276 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A5 RID: 26277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E3")]
		[CanBeNull]
		public ILocation Location
		{
			[Token(Token = "0x60066A4")]
			[Address(RVA = "0xB225", Offset = "0xB225", VA = "0xB225", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A5")]
			[Address(RVA = "0xB226", Offset = "0xB226", VA = "0xB226", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E4 RID: 5348
		// (get) Token: 0x060066A6 RID: 26278 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A7 RID: 26279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E4")]
		[CanBeNull]
		public IClientState ClientState
		{
			[Token(Token = "0x60066A6")]
			[Address(RVA = "0xB227", Offset = "0xB227", VA = "0xB227", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A7")]
			[Address(RVA = "0xB228", Offset = "0xB228", VA = "0xB228", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170014E5 RID: 5349
		// (get) Token: 0x060066A8 RID: 26280 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060066A9 RID: 26281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014E5")]
		[CanBeNull]
		public IGame Game
		{
			[Token(Token = "0x60066A8")]
			[Address(RVA = "0xB229", Offset = "0xB229", VA = "0xB229", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60066A9")]
			[Address(RVA = "0xB22A", Offset = "0xB22A", VA = "0xB22A", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060066AA RID: 26282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AA")]
		[Address(RVA = "0xB22B", Offset = "0xB22B", VA = "0xB22B", Slot = "13")]
		public void Dispose()
		{
		}

		// Token: 0x060066AB RID: 26283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AB")]
		[Address(RVA = "0xB22C", Offset = "0xB22C", VA = "0xB22C")]
		public RecoveryConnectionHelper(PlatformSigninManager platformSignin)
		{
		}

		// Token: 0x060066AC RID: 26284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AC")]
		[Address(RVA = "0xB22D", Offset = "0xB22D", VA = "0xB22D", Slot = "12")]
		public void Resolve()
		{
		}

		// Token: 0x060066AD RID: 26285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066AD")]
		[Address(RVA = "0xB22E", Offset = "0xB22E", VA = "0xB22E")]
		private void Handler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040036DA RID: 14042
		[Token(Token = "0x40036DA")]
		[FieldOffset(Offset = "0x8")]
		private PlatformSigninManager _platformSignin;
	}
}

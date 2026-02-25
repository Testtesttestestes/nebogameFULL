using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using ServicesNamespace;
using Utils;

namespace Core.Gameplay.Managers.Location
{
	// Token: 0x020011BD RID: 4541
	[Token(Token = "0x20011BD")]
	public class LocationManager : ILocation, IGameManager, IBaseManager
	{
		// Token: 0x140002C1 RID: 705
		// (add) Token: 0x06006BF5 RID: 27637 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006BF6 RID: 27638 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C1")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006BF5")]
			[Address(RVA = "0xB6E4", Offset = "0xB6E4", VA = "0xB6E4", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006BF6")]
			[Address(RVA = "0xB6E5", Offset = "0xB6E5", VA = "0xB6E5", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002C2 RID: 706
		// (add) Token: 0x06006BF7 RID: 27639 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006BF8 RID: 27640 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002C2")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006BF7")]
			[Address(RVA = "0xB6E6", Offset = "0xB6E6", VA = "0xB6E6", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006BF8")]
			[Address(RVA = "0xB6E7", Offset = "0xB6E7", VA = "0xB6E7", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700160E RID: 5646
		// (get) Token: 0x06006BF9 RID: 27641 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006BFA RID: 27642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700160E")]
		public IGame Game
		{
			[Token(Token = "0x6006BF9")]
			[Address(RVA = "0xB6E8", Offset = "0xB6E8", VA = "0xB6E8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006BFA")]
			[Address(RVA = "0xB6E9", Offset = "0xB6E9", VA = "0xB6E9")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700160F RID: 5647
		// (get) Token: 0x06006BFB RID: 27643 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700160F")]
		public string Name
		{
			[Token(Token = "0x6006BFB")]
			[Address(RVA = "0xB6EA", Offset = "0xB6EA", VA = "0xB6EA", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFC")]
		[Address(RVA = "0xB6EB", Offset = "0xB6EB", VA = "0xB6EB")]
		public LocationManager(IGame game)
		{
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFD")]
		[Address(RVA = "0xB6EC", Offset = "0xB6EC", VA = "0xB6EC", Slot = "9")]
		public void Init()
		{
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BFE")]
		[Address(RVA = "0xB6ED", Offset = "0xB6ED", VA = "0xB6ED", Slot = "10")]
		public void Deinit()
		{
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x00013FE0 File Offset: 0x000121E0
		[Token(Token = "0x6006BFF")]
		[Address(RVA = "0xB6EE", Offset = "0xB6EE", VA = "0xB6EE", Slot = "4")]
		public UniTask ForwardLocation()
		{
			return default(UniTask);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C00")]
		[Address(RVA = "0xB6EF", Offset = "0xB6EF", VA = "0xB6EF")]
		private void CurrentIsleChangedEvent(ulong prevOwnerId = 0UL)
		{
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006C01")]
		[Address(RVA = "0xB6F0", Offset = "0xB6F0", VA = "0xB6F0")]
		private void ChangeLocationSuccessHandler(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x040038DB RID: 14555
		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x10")]
		private LocationService _locationService;

		// Token: 0x040038DC RID: 14556
		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x14")]
		private bool _isInitialized;

		// Token: 0x040038DE RID: 14558
		[Token(Token = "0x40038DE")]
		[FieldOffset(Offset = "0x1C")]
		private OpTokenRepository _tokenRepository;
	}
}

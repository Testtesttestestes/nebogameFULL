using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Google.Protobuf;
using Il2CppDummyDll;
using Protocol.Main;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200114E RID: 4430
	[Token(Token = "0x200114E")]
	public class ClientStateManager : IClientState, IGameManager, IBaseManager
	{
		// Token: 0x14000270 RID: 624
		// (add) Token: 0x06006858 RID: 26712 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006859 RID: 26713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000270")]
		public event ClientStateManager.ClientStateChangedDelegate OnClientStateChangedEvent
		{
			[Token(Token = "0x6006858")]
			[Address(RVA = "0xB383", Offset = "0xB383", VA = "0xB383")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006859")]
			[Address(RVA = "0xB384", Offset = "0xB384", VA = "0xB384")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x0600685A RID: 26714 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600685B RID: 26715 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001560")]
		public IGame Game
		{
			[Token(Token = "0x600685A")]
			[Address(RVA = "0xB385", Offset = "0xB385", VA = "0xB385")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600685B")]
			[Address(RVA = "0xB386", Offset = "0xB386", VA = "0xB386")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600685C RID: 26716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600685C")]
		[Address(RVA = "0xB387", Offset = "0xB387", VA = "0xB387")]
		public ClientStateManager(IGame game)
		{
		}

		// Token: 0x17001561 RID: 5473
		// (get) Token: 0x0600685D RID: 26717 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600685E RID: 26718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001561")]
		public ProtoGetClientStateAns CurrentState
		{
			[Token(Token = "0x600685D")]
			[Address(RVA = "0xB388", Offset = "0xB388", VA = "0xB388")]
			get
			{
				return null;
			}
			[Token(Token = "0x600685E")]
			[Address(RVA = "0xB389", Offset = "0xB389", VA = "0xB389")]
			set
			{
			}
		}

		// Token: 0x0600685F RID: 26719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600685F")]
		[Address(RVA = "0xB38A", Offset = "0xB38A", VA = "0xB38A")]
		private void HandleInitializeComplete()
		{
		}

		// Token: 0x06006860 RID: 26720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xB38B", Offset = "0xB38B", VA = "0xB38B")]
		public void RequestClientState()
		{
		}

		// Token: 0x06006861 RID: 26721 RVA: 0x00013908 File Offset: 0x00011B08
		[Token(Token = "0x6006861")]
		[Address(RVA = "0xB38C", Offset = "0xB38C", VA = "0xB38C", Slot = "4")]
		public UniTask ForceRequestClientState()
		{
			return default(UniTask);
		}

		// Token: 0x06006862 RID: 26722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006862")]
		[Address(RVA = "0xB38D", Offset = "0xB38D", VA = "0xB38D")]
		private void HandleGetClientStateRequest(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x06006863 RID: 26723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006863")]
		[Address(RVA = "0xB38E", Offset = "0xB38E", VA = "0xB38E")]
		private void HandleGetClientStateRequestForceUpdate(OpToken<IMessage, object> op)
		{
		}

		// Token: 0x14000271 RID: 625
		// (add) Token: 0x06006864 RID: 26724 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006865 RID: 26725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000271")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006864")]
			[Address(RVA = "0xB38F", Offset = "0xB38F", VA = "0xB38F", Slot = "5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006865")]
			[Address(RVA = "0xB390", Offset = "0xB390", VA = "0xB390", Slot = "6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000272 RID: 626
		// (add) Token: 0x06006866 RID: 26726 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006867 RID: 26727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000272")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006866")]
			[Address(RVA = "0xB391", Offset = "0xB391", VA = "0xB391", Slot = "7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006867")]
			[Address(RVA = "0xB392", Offset = "0xB392", VA = "0xB392", Slot = "8")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001562 RID: 5474
		// (get) Token: 0x06006868 RID: 26728 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001562")]
		public string Name
		{
			[Token(Token = "0x6006868")]
			[Address(RVA = "0xB393", Offset = "0xB393", VA = "0xB393", Slot = "11")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006869 RID: 26729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006869")]
		[Address(RVA = "0xB394", Offset = "0xB394", VA = "0xB394", Slot = "9")]
		public void Init()
		{
		}

		// Token: 0x0600686A RID: 26730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600686A")]
		[Address(RVA = "0xB395", Offset = "0xB395", VA = "0xB395", Slot = "10")]
		public void Deinit()
		{
		}

		// Token: 0x0400378F RID: 14223
		[Token(Token = "0x400378F")]
		[FieldOffset(Offset = "0xC")]
		private ProtoGetClientStateAns _currentState;

		// Token: 0x04003790 RID: 14224
		[Token(Token = "0x4003790")]
		[FieldOffset(Offset = "0x10")]
		private OpTokenRepository _tokenRepository;

		// Token: 0x0200114F RID: 4431
		// (Invoke) Token: 0x0600686C RID: 26732
		[Token(Token = "0x200114F")]
		public delegate void ClientStateChangedDelegate(ProtoGetClientStateAns fromState, ProtoGetClientStateAns toState);
	}
}

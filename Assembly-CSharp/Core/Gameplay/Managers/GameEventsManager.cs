using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents;
using Gameplay.GameEvents.Control;
using Gameplay.GameEvents.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Gameplay.Managers
{
	// Token: 0x02001168 RID: 4456
	[Token(Token = "0x2001168")]
	public class GameEventsManager : IGameManager, IBaseManager
	{
		// Token: 0x14000288 RID: 648
		// (add) Token: 0x0600692C RID: 26924 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600692D RID: 26925 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000288")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600692C")]
			[Address(RVA = "0xB450", Offset = "0xB450", VA = "0xB450", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600692D")]
			[Address(RVA = "0xB451", Offset = "0xB451", VA = "0xB451", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000289 RID: 649
		// (add) Token: 0x0600692E RID: 26926 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600692F RID: 26927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000289")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600692E")]
			[Address(RVA = "0xB452", Offset = "0xB452", VA = "0xB452", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600692F")]
			[Address(RVA = "0xB453", Offset = "0xB453", VA = "0xB453", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06006930 RID: 26928 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006931 RID: 26929 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001585")]
		public IGame Game
		{
			[Token(Token = "0x6006930")]
			[Address(RVA = "0xB454", Offset = "0xB454", VA = "0xB454")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006931")]
			[Address(RVA = "0xB455", Offset = "0xB455", VA = "0xB455")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006932 RID: 26930 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006932")]
		[Address(RVA = "0xB456", Offset = "0xB456", VA = "0xB456")]
		public GameEventsManager(IGame game)
		{
		}

		// Token: 0x06006933 RID: 26931 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006933")]
		[Address(RVA = "0xB457", Offset = "0xB457", VA = "0xB457", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06006934 RID: 26932 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001586")]
		public GameEventsController Controller
		{
			[Token(Token = "0x6006934")]
			[Address(RVA = "0xB458", Offset = "0xB458", VA = "0xB458")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006935 RID: 26933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006935")]
		[Address(RVA = "0xB459", Offset = "0xB459", VA = "0xB459")]
		public void SetView(UserInterfaceView view)
		{
		}

		// Token: 0x06006936 RID: 26934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006936")]
		[Address(RVA = "0xB45A", Offset = "0xB45A", VA = "0xB45A")]
		public void OpenListView(EventCategoriesDic.Types.Category cat)
		{
		}

		// Token: 0x06006937 RID: 26935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006937")]
		[Address(RVA = "0xB45B", Offset = "0xB45B", VA = "0xB45B")]
		private void HandleFeatureInitEvent()
		{
		}

		// Token: 0x06006938 RID: 26936 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006938")]
		[Address(RVA = "0xB45C", Offset = "0xB45C", VA = "0xB45C", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06006939 RID: 26937 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001587")]
		public string Name
		{
			[Token(Token = "0x6006939")]
			[Address(RVA = "0xB45D", Offset = "0xB45D", VA = "0xB45D", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x040037D6 RID: 14294
		[Token(Token = "0x40037D6")]
		[FieldOffset(Offset = "0x14")]
		private GameEventsEvents _events;

		// Token: 0x040037D7 RID: 14295
		[Token(Token = "0x40037D7")]
		[FieldOffset(Offset = "0x18")]
		private GameEventsModel _model;

		// Token: 0x040037D8 RID: 14296
		[Token(Token = "0x40037D8")]
		[FieldOffset(Offset = "0x1C")]
		private GameEventsController _controller;

		// Token: 0x040037D9 RID: 14297
		[Token(Token = "0x40037D9")]
		[FieldOffset(Offset = "0x20")]
		private GameEventsEnterPointViewMediator _mediator;
	}
}

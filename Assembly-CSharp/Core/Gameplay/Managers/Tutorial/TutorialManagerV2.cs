using System;
using System.Runtime.CompilerServices;
using Core.Cache.User;
using Core.Data;
using Gameplay.Combat.View;
using Gameplay.TutorialV2.Controller;
using Gameplay.TutorialV2.Events;
using Gameplay.TutorialV2.Model;
using Gameplay.TutorialV2.View;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.World;

namespace Core.Gameplay.Managers.Tutorial
{
	// Token: 0x02001184 RID: 4484
	[Token(Token = "0x2001184")]
	public class TutorialManagerV2 : IGameManager, IBaseManager, ITutorialManager
	{
		// Token: 0x170015CC RID: 5580
		// (get) Token: 0x06006A7C RID: 27260 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A7D RID: 27261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CC")]
		public IGame Game
		{
			[Token(Token = "0x6006A7C")]
			[Address(RVA = "0xB595", Offset = "0xB595", VA = "0xB595", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A7D")]
			[Address(RVA = "0xB596", Offset = "0xB596", VA = "0xB596")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A7E")]
		[Address(RVA = "0xB597", Offset = "0xB597", VA = "0xB597")]
		public TutorialManagerV2(IGame game)
		{
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06006A7F RID: 27263 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170015CD")]
		public string Name
		{
			[Token(Token = "0x6006A7F")]
			[Address(RVA = "0xB598", Offset = "0xB598", VA = "0xB598", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x140002B0 RID: 688
		// (add) Token: 0x06006A80 RID: 27264 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A81 RID: 27265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B0")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x6006A80")]
			[Address(RVA = "0xB599", Offset = "0xB599", VA = "0xB599", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A81")]
			[Address(RVA = "0xB59A", Offset = "0xB59A", VA = "0xB59A", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140002B1 RID: 689
		// (add) Token: 0x06006A82 RID: 27266 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06006A83 RID: 27267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140002B1")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x6006A82")]
			[Address(RVA = "0xB59B", Offset = "0xB59B", VA = "0xB59B", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6006A83")]
			[Address(RVA = "0xB59C", Offset = "0xB59C", VA = "0xB59C", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x06006A84 RID: 27268 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A85 RID: 27269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CE")]
		public TutorialEvents Events
		{
			[Token(Token = "0x6006A84")]
			[Address(RVA = "0xB59D", Offset = "0xB59D", VA = "0xB59D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A85")]
			[Address(RVA = "0xB59E", Offset = "0xB59E", VA = "0xB59E")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x06006A86 RID: 27270 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A87 RID: 27271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015CF")]
		public TutorialModel Model
		{
			[Token(Token = "0x6006A86")]
			[Address(RVA = "0xB59F", Offset = "0xB59F", VA = "0xB59F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A87")]
			[Address(RVA = "0xB5A0", Offset = "0xB5A0", VA = "0xB5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x06006A88 RID: 27272 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A89 RID: 27273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D0")]
		public TutorialController Controller
		{
			[Token(Token = "0x6006A88")]
			[Address(RVA = "0xB5A1", Offset = "0xB5A1", VA = "0xB5A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A89")]
			[Address(RVA = "0xB5A2", Offset = "0xB5A2", VA = "0xB5A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06006A8A RID: 27274 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06006A8B RID: 27275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015D1")]
		public TutorialViewMediator Mediator
		{
			[Token(Token = "0x6006A8A")]
			[Address(RVA = "0xB5A3", Offset = "0xB5A3", VA = "0xB5A3")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006A8B")]
			[Address(RVA = "0xB5A4", Offset = "0xB5A4", VA = "0xB5A4")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06006A8C RID: 27276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8C")]
		[Address(RVA = "0xB5A5", Offset = "0xB5A5", VA = "0xB5A5", Slot = "12")]
		public void SetView(ITutorialView view)
		{
		}

		// Token: 0x06006A8D RID: 27277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A8D")]
		[Address(RVA = "0xB5A6", Offset = "0xB5A6", VA = "0xB5A6", Slot = "13")]
		public void SetCombatView(OneOnOneCombatView view)
		{
		}

		// Token: 0x06006A8E RID: 27278 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A8E")]
		[Address(RVA = "0xB5A7", Offset = "0xB5A7", VA = "0xB5A7", Slot = "14")]
		public UserData GetUser()
		{
			return null;
		}

		// Token: 0x06006A8F RID: 27279 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6006A8F")]
		[Address(RVA = "0xB5A8", Offset = "0xB5A8", VA = "0xB5A8", Slot = "15")]
		public RepeatedField<ProtoGetUserIsleInfoAns.Types.IsleInformation> GetIsles()
		{
			return null;
		}

		// Token: 0x06006A90 RID: 27280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A90")]
		[Address(RVA = "0xB5A9", Offset = "0xB5A9", VA = "0xB5A9", Slot = "16")]
		public void CreateUser(IUserCache cache)
		{
		}

		// Token: 0x06006A91 RID: 27281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A91")]
		[Address(RVA = "0xB5AA", Offset = "0xB5AA", VA = "0xB5AA", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006A92 RID: 27282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A92")]
		[Address(RVA = "0xB5AB", Offset = "0xB5AB", VA = "0xB5AB")]
		private void OnInitCompleteTutorial()
		{
		}

		// Token: 0x06006A93 RID: 27283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006A93")]
		[Address(RVA = "0xB5AC", Offset = "0xB5AC", VA = "0xB5AC", Slot = "9")]
		public void Deinit()
		{
		}
	}
}

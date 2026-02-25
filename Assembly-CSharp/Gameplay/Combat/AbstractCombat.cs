using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Gameplay;
using Gameplay.Combat.Control;
using Gameplay.Combat.Events;
using Gameplay.Combat.Model;
using Gameplay.Combat.View;
using Il2CppDummyDll;
using Protocol.Common;
using Utils;

namespace Gameplay.Combat
{
	// Token: 0x02000913 RID: 2323
	[Token(Token = "0x2000913")]
	public abstract class AbstractCombat<TModel, TEvents, TController, TViewMediator, TView> : ICombat, IDisposable, IManageCombat where TModel : CombatModel where TEvents : CombatEvents where TController : CombatController<TModel, TEvents> where TViewMediator : AbstractCombatViewMediator<TModel, TEvents, TController, TView> where TView : AbstractCombatView
	{
		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06003695 RID: 13973 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003696 RID: 13974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC0")]
		public UserData LoggedUser
		{
			[Token(Token = "0x6003695")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003696")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC1")]
		public UserData User
		{
			[Token(Token = "0x6003697")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003698")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003699 RID: 13977 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600369A RID: 13978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC2")]
		public BackTime AwaitBackTime
		{
			[Token(Token = "0x6003699")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600369A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x0600369B RID: 13979 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600369C RID: 13980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC3")]
		public TModel Model
		{
			[Token(Token = "0x600369B")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600369C")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC4")]
		public TViewMediator Mediator
		{
			[Token(Token = "0x600369D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600369E")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x0600369F RID: 13983 RVA: 0x0000AF38 File Offset: 0x00009138
		// (set) Token: 0x060036A0 RID: 13984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC5")]
		public bool IsRun
		{
			[Token(Token = "0x600369F")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60036A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x060036A1 RID: 13985 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060036A2 RID: 13986 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000AC6")]
		public IGame Game
		{
			[Token(Token = "0x60036A1")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60036A2")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060036A3 RID: 13987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036A3")]
		public void SetView(AbstractCombatView view)
		{
		}

		// Token: 0x060036A4 RID: 13988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036A4")]
		public virtual void Dispose()
		{
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036A5")]
		public AbstractCombat(IGame game, UserData loggedUser, UserData user, BackTime awaitBackTime)
		{
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x60036A6")]
		public bool TryRun(ResourceSet price)
		{
			return default(bool);
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x0000AF68 File Offset: 0x00009168
		[Token(Token = "0x60036A7")]
		public bool TryRun()
		{
			return default(bool);
		}

		// Token: 0x060036A8 RID: 13992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60036A8")]
		public void Stop()
		{
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0000AF80 File Offset: 0x00009180
		[Token(Token = "0x60036A9")]
		public CombatModel.States GetState()
		{
			return CombatModel.States.None;
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x60036AA")]
		protected virtual bool CheckRunRestrictions()
		{
			return default(bool);
		}

		// Token: 0x060036AB RID: 13995
		[Token(Token = "0x60036AB")]
		protected abstract void InitMVC();

		// Token: 0x04001DE2 RID: 7650
		[Token(Token = "0x4001DE2")]
		public const string OneOnOneCombatLocalPropsStorageName = "OneOnOneCombatLocalProps";

		// Token: 0x04001DE5 RID: 7653
		[Token(Token = "0x4001DE5")]
		[FieldOffset(Offset = "0x0")]
		protected TController _controller;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CloudsFly.Movement;
using DG.Tweening;
using Il2CppDummyDll;
using UI.Windows;
using Utils;

namespace Core.Gameplay.Managers
{
	// Token: 0x0200116B RID: 4459
	[Token(Token = "0x200116B")]
	public class PopupScheduleManager : IGameManager, IBaseManager
	{
		// Token: 0x1700158F RID: 5519
		// (get) Token: 0x0600695B RID: 26971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700158F")]
		public string Name
		{
			[Token(Token = "0x600695B")]
			[Address(RVA = "0xB47F", Offset = "0xB47F", VA = "0xB47F", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400028E RID: 654
		// (add) Token: 0x0600695C RID: 26972 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600695D RID: 26973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028E")]
		public event Action<IBaseManager> InitCompleteEvent
		{
			[Token(Token = "0x600695C")]
			[Address(RVA = "0xB480", Offset = "0xB480", VA = "0xB480", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600695D")]
			[Address(RVA = "0xB481", Offset = "0xB481", VA = "0xB481", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400028F RID: 655
		// (add) Token: 0x0600695E RID: 26974 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600695F RID: 26975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400028F")]
		public event Action<IBaseManager> DeinitCompleteEvent
		{
			[Token(Token = "0x600695E")]
			[Address(RVA = "0xB482", Offset = "0xB482", VA = "0xB482", Slot = "6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600695F")]
			[Address(RVA = "0xB483", Offset = "0xB483", VA = "0xB483", Slot = "7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06006960 RID: 26976 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006960")]
		[Address(RVA = "0xB484", Offset = "0xB484", VA = "0xB484")]
		public PopupScheduleManager(IGame game)
		{
		}

		// Token: 0x17001590 RID: 5520
		// (get) Token: 0x06006961 RID: 26977 RVA: 0x00013980 File Offset: 0x00011B80
		[Token(Token = "0x17001590")]
		public bool IsPlayerIdle
		{
			[Token(Token = "0x6006961")]
			[Address(RVA = "0xB485", Offset = "0xB485", VA = "0xB485")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006962")]
		[Address(RVA = "0xB486", Offset = "0xB486", VA = "0xB486", Slot = "9")]
		public void Deinit()
		{
		}

		// Token: 0x06006963 RID: 26979 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006963")]
		[Address(RVA = "0xB487", Offset = "0xB487", VA = "0xB487", Slot = "8")]
		public void Init()
		{
		}

		// Token: 0x06006964 RID: 26980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006964")]
		[Address(RVA = "0xB488", Offset = "0xB488", VA = "0xB488")]
		private void HandleOnWindowClosedEvent(string windowId, WindowCloseReason closeReason)
		{
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006965")]
		[Address(RVA = "0xB489", Offset = "0xB489", VA = "0xB489")]
		private void MovCompleteEvent(WorldMovementTypes type)
		{
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006966")]
		[Address(RVA = "0xB48A", Offset = "0xB48A", VA = "0xB48A")]
		private void OpenFirstAvailableWindow(PopupScheduleManager.Args.TriggeredRights rights)
		{
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006967")]
		public void ScheduleOpenWindow<T>(in PopupScheduleManager.Args args, params Func<bool>[] extraChecks) where T : BaseWindow
		{
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006968")]
		[Address(RVA = "0xB48B", Offset = "0xB48B", VA = "0xB48B")]
		public void UnScheduleOpenWindow(in PopupScheduleManager.Args args)
		{
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006969")]
		[Address(RVA = "0xB48C", Offset = "0xB48C", VA = "0xB48C")]
		public void OpenNextAvailableWindow(PopupScheduleManager.Args.TriggeredRights rights)
		{
		}

		// Token: 0x0600696A RID: 26986 RVA: 0x00013998 File Offset: 0x00011B98
		[Token(Token = "0x600696A")]
		[Address(RVA = "0xB48D", Offset = "0xB48D", VA = "0xB48D")]
		private bool TryOpenWindow(PopupScheduleManager.ScheduleInfo info)
		{
			return default(bool);
		}

		// Token: 0x0600696B RID: 26987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696B")]
		[Address(RVA = "0xB48E", Offset = "0xB48E", VA = "0xB48E")]
		private void ScheduleNext(PopupScheduleManager.ScheduleInfo info)
		{
		}

		// Token: 0x0600696C RID: 26988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600696C")]
		[Address(RVA = "0xB48F", Offset = "0xB48F", VA = "0xB48F")]
		private void OpenNextAvailableWindowDelayed(PopupScheduleManager.Args.TriggeredRights rights)
		{
		}

		// Token: 0x040037E3 RID: 14307
		[Token(Token = "0x40037E3")]
		private const float DELAY_OPEN = 0.3f;

		// Token: 0x040037E6 RID: 14310
		[Token(Token = "0x40037E6")]
		[FieldOffset(Offset = "0x10")]
		private readonly List<PopupScheduleManager.ScheduleInfo> _scheduledWindows;

		// Token: 0x040037E7 RID: 14311
		[Token(Token = "0x40037E7")]
		[FieldOffset(Offset = "0x14")]
		private Tween _delayTween;

		// Token: 0x040037E8 RID: 14312
		[Token(Token = "0x40037E8")]
		[FieldOffset(Offset = "0x18")]
		private IGame _game;

		// Token: 0x0200116C RID: 4460
		[Token(Token = "0x200116C")]
		public class Args
		{
			// Token: 0x0600696D RID: 26989 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600696D")]
			[Address(RVA = "0xB490", Offset = "0xB490", VA = "0xB490")]
			public Args(PopupScheduleManager.Args.TriggeredRights rights)
			{
			}

			// Token: 0x0600696E RID: 26990 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600696E")]
			[Address(RVA = "0xB491", Offset = "0xB491", VA = "0xB491")]
			public Args()
			{
			}

			// Token: 0x040037E9 RID: 14313
			[Token(Token = "0x40037E9")]
			[FieldOffset(Offset = "0x8")]
			public int RepeatTimes;

			// Token: 0x040037EA RID: 14314
			[Token(Token = "0x40037EA")]
			[FieldOffset(Offset = "0xC")]
			public float DelaySeconds;

			// Token: 0x040037EB RID: 14315
			[Token(Token = "0x40037EB")]
			[FieldOffset(Offset = "0x10")]
			public Action OpenAction;

			// Token: 0x040037EC RID: 14316
			[Token(Token = "0x40037EC")]
			[FieldOffset(Offset = "0x14")]
			public readonly PopupScheduleManager.Args.TriggeredRights Rights;

			// Token: 0x0200116D RID: 4461
			[Token(Token = "0x200116D")]
			[Flags]
			public enum TriggeredRights
			{
				// Token: 0x040037EE RID: 14318
				[Token(Token = "0x40037EE")]
				None = 0,
				// Token: 0x040037EF RID: 14319
				[Token(Token = "0x40037EF")]
				ForceRun = 1,
				// Token: 0x040037F0 RID: 14320
				[Token(Token = "0x40037F0")]
				WorldMovement = 2,
				// Token: 0x040037F1 RID: 14321
				[Token(Token = "0x40037F1")]
				PopupCountChanged = 4
			}
		}

		// Token: 0x0200116E RID: 4462
		[Token(Token = "0x200116E")]
		private class ScheduleInfo<T> : PopupScheduleManager.ScheduleInfo
		{
			// Token: 0x17001591 RID: 5521
			// (get) Token: 0x0600696F RID: 26991 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17001591")]
			public override Type Type
			{
				[Token(Token = "0x600696F")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006970 RID: 26992 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006970")]
			public ScheduleInfo(PopupScheduleManager.Args args, Func<bool>[] extraChecks)
			{
			}
		}

		// Token: 0x0200116F RID: 4463
		[Token(Token = "0x200116F")]
		private abstract class ScheduleInfo
		{
			// Token: 0x17001592 RID: 5522
			// (get) Token: 0x06006971 RID: 26993
			[Token(Token = "0x17001592")]
			public abstract Type Type { [Token(Token = "0x6006971")] get; }

			// Token: 0x06006972 RID: 26994 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6006972")]
			[Address(RVA = "0xB492", Offset = "0xB492", VA = "0xB492")]
			protected ScheduleInfo(PopupScheduleManager.Args args, Func<bool>[] extraChecks)
			{
			}

			// Token: 0x040037F2 RID: 14322
			[Token(Token = "0x40037F2")]
			[FieldOffset(Offset = "0x8")]
			public readonly PopupScheduleManager.Args Args;

			// Token: 0x040037F3 RID: 14323
			[Token(Token = "0x40037F3")]
			[FieldOffset(Offset = "0xC")]
			public readonly Func<bool>[] ExtraChecks;

			// Token: 0x040037F4 RID: 14324
			[Token(Token = "0x40037F4")]
			[FieldOffset(Offset = "0x10")]
			public BackTime BackTime;
		}
	}
}

using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	public abstract class AbstractActionOnEvent : IDisposable
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002EE0 RID: 12000 RVA: 0x000097E0 File Offset: 0x000079E0
		[Token(Token = "0x17000923")]
		public uint Id
		{
			[Token(Token = "0x6002EE0")]
			[Address(RVA = "0x7F4F", Offset = "0x7F4F", VA = "0x7F4F")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06002EE1 RID: 12001 RVA: 0x000097F8 File Offset: 0x000079F8
		[Token(Token = "0x17000924")]
		public EventActionDic.Types.BehaviorTypes BehaviorType
		{
			[Token(Token = "0x6002EE1")]
			[Address(RVA = "0x7F50", Offset = "0x7F50", VA = "0x7F50")]
			get
			{
				return EventActionDic.Types.BehaviorTypes.UnknownBehaviorType;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06002EE2 RID: 12002 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002EE3 RID: 12003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000925")]
		public GameEventData EventData
		{
			[Token(Token = "0x6002EE2")]
			[Address(RVA = "0x7F51", Offset = "0x7F51", VA = "0x7F51")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EE3")]
			[Address(RVA = "0x7F52", Offset = "0x7F52", VA = "0x7F52")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000926")]
		public string Label
		{
			[Token(Token = "0x6002EE4")]
			[Address(RVA = "0x7F53", Offset = "0x7F53", VA = "0x7F53")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002EE5")]
			[Address(RVA = "0x7F54", Offset = "0x7F54", VA = "0x7F54")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x00009810 File Offset: 0x00007A10
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000927")]
		public bool Selected
		{
			[Token(Token = "0x6002EE6")]
			[Address(RVA = "0x7F55", Offset = "0x7F55", VA = "0x7F55")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002EE7")]
			[Address(RVA = "0x7F56", Offset = "0x7F56", VA = "0x7F56")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EE8")]
		[Address(RVA = "0x7F57", Offset = "0x7F57", VA = "0x7F57", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06002EE9 RID: 12009
		[Token(Token = "0x17000928")]
		public abstract uint SortOrder { [Token(Token = "0x6002EE9")] get; }

		// Token: 0x06002EEA RID: 12010
		[Token(Token = "0x6002EEA")]
		public abstract void Execute(GameEventsController controller);

		// Token: 0x06002EEB RID: 12011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EEB")]
		[Address(RVA = "0x7F58", Offset = "0x7F58", VA = "0x7F58")]
		protected AbstractActionOnEvent()
		{
		}

		// Token: 0x040019A8 RID: 6568
		[Token(Token = "0x40019A8")]
		[FieldOffset(Offset = "0x8")]
		public EventActionDic EventActionDic;

		// Token: 0x040019A9 RID: 6569
		[Token(Token = "0x40019A9")]
		[FieldOffset(Offset = "0xC")]
		public EventTypeDic.Types.ActionParams ActionParamsConfig;
	}
}

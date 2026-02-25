using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Core.Data.Effect
{
	// Token: 0x020010EB RID: 4331
	[Token(Token = "0x20010EB")]
	public class EffectData
	{
		// Token: 0x1700147E RID: 5246
		// (get) Token: 0x0600653B RID: 25915 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600653C RID: 25916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147E")]
		public EffectDic EffectDic
		{
			[Token(Token = "0x600653B")]
			[Address(RVA = "0xB107", Offset = "0xB107", VA = "0xB107")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600653C")]
			[Address(RVA = "0xB108", Offset = "0xB108", VA = "0xB108")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700147F RID: 5247
		// (get) Token: 0x0600653D RID: 25917 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600653E RID: 25918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700147F")]
		public EffectLevelDic EffectLevelDic
		{
			[Token(Token = "0x600653D")]
			[Address(RVA = "0xB109", Offset = "0xB109", VA = "0xB109")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600653E")]
			[Address(RVA = "0xB10A", Offset = "0xB10A", VA = "0xB10A")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001480 RID: 5248
		// (get) Token: 0x0600653F RID: 25919 RVA: 0x00013410 File Offset: 0x00011610
		// (set) Token: 0x06006540 RID: 25920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001480")]
		public uint LeftTurns
		{
			[Token(Token = "0x600653F")]
			[Address(RVA = "0xB10B", Offset = "0xB10B", VA = "0xB10B")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6006540")]
			[Address(RVA = "0xB10C", Offset = "0xB10C", VA = "0xB10C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001481 RID: 5249
		// (get) Token: 0x06006541 RID: 25921 RVA: 0x00013428 File Offset: 0x00011628
		// (set) Token: 0x06006542 RID: 25922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001481")]
		public uint TimeLeft
		{
			[Token(Token = "0x6006541")]
			[Address(RVA = "0xB10D", Offset = "0xB10D", VA = "0xB10D")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6006542")]
			[Address(RVA = "0xB10E", Offset = "0xB10E", VA = "0xB10E")]
			set
			{
			}
		}

		// Token: 0x06006543 RID: 25923 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006543")]
		[Address(RVA = "0xB10F", Offset = "0xB10F", VA = "0xB10F")]
		public EffectData(EffectDic effectDic, EffectLevelDic levelDic)
		{
		}

		// Token: 0x17001482 RID: 5250
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x00013440 File Offset: 0x00011640
		[Token(Token = "0x17001482")]
		public long Duration
		{
			[Token(Token = "0x6006544")]
			[Address(RVA = "0xB110", Offset = "0xB110", VA = "0xB110")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001483 RID: 5251
		// (get) Token: 0x06006545 RID: 25925 RVA: 0x00013458 File Offset: 0x00011658
		[Token(Token = "0x17001483")]
		public long CurrentDuration
		{
			[Token(Token = "0x6006545")]
			[Address(RVA = "0xB111", Offset = "0xB111", VA = "0xB111")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001484 RID: 5252
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x00013470 File Offset: 0x00011670
		[Token(Token = "0x17001484")]
		public long MaxStack
		{
			[Token(Token = "0x6006546")]
			[Address(RVA = "0xB112", Offset = "0xB112", VA = "0xB112")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x17001485 RID: 5253
		// (get) Token: 0x06006547 RID: 25927 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001485")]
		public AbstractEffectDescription Description
		{
			[Token(Token = "0x6006547")]
			[Address(RVA = "0xB113", Offset = "0xB113", VA = "0xB113")]
			get
			{
				return null;
			}
		}

		// Token: 0x04003621 RID: 13857
		[Token(Token = "0x4003621")]
		[FieldOffset(Offset = "0x10")]
		public ulong OwnerUserId;

		// Token: 0x04003622 RID: 13858
		[Token(Token = "0x4003622")]
		[FieldOffset(Offset = "0x18")]
		public int CurrentStackSize;

		// Token: 0x04003624 RID: 13860
		[Token(Token = "0x4003624")]
		[FieldOffset(Offset = "0x20")]
		private long _finishTime;

		// Token: 0x04003625 RID: 13861
		[Token(Token = "0x4003625")]
		[FieldOffset(Offset = "0x28")]
		private uint _timeLeft;

		// Token: 0x04003626 RID: 13862
		[Token(Token = "0x4003626")]
		[FieldOffset(Offset = "0x2C")]
		public List<ModifierData> Mods;

		// Token: 0x04003627 RID: 13863
		[Token(Token = "0x4003627")]
		[FieldOffset(Offset = "0x30")]
		private AbstractEffectDescription _description;
	}
}

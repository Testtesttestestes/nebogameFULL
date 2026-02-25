using System;
using System.Runtime.CompilerServices;
using Core.Application;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.SmallGames;

namespace Core.Events.Scopes
{
	// Token: 0x02001029 RID: 4137
	[Token(Token = "0x2001029")]
	public class SmallGamesScope : AbstractEventBusScope
	{
		// Token: 0x060061AC RID: 25004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AC")]
		[Address(RVA = "0xADD7", Offset = "0xADD7", VA = "0xADD7", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x060061AD RID: 25005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60061AD")]
		[Address(RVA = "0xADD8", Offset = "0xADD8", VA = "0xADD8")]
		public SmallGamesScope()
		{
		}

		// Token: 0x04003481 RID: 13441
		[Token(Token = "0x4003481")]
		[FieldOffset(Offset = "0x8")]
		public Action<BaseEventBusEventArgs> DailyBonusTakenEvent;

		// Token: 0x04003482 RID: 13442
		[Token(Token = "0x4003482")]
		[FieldOffset(Offset = "0xC")]
		public Action<SmallGamesScope.SlotMachineSpinEventArgs> SlotMachineSpinEvent;

		// Token: 0x0200102A RID: 4138
		[Token(Token = "0x200102A")]
		public class SlotMachineSpinEventArgs : BaseEventBusEventArgs
		{
			// Token: 0x17001377 RID: 4983
			// (get) Token: 0x060061AE RID: 25006 RVA: 0x00011F88 File Offset: 0x00010188
			[Token(Token = "0x17001377")]
			public SlotMachineType SlotMachineType
			{
				[Token(Token = "0x60061AE")]
				[Address(RVA = "0xADD9", Offset = "0xADD9", VA = "0xADD9")]
				[CompilerGenerated]
				get
				{
					return SlotMachineType.UnknownMachine;
				}
			}

			// Token: 0x17001378 RID: 4984
			// (get) Token: 0x060061AF RID: 25007 RVA: 0x00011FA0 File Offset: 0x000101A0
			[Token(Token = "0x17001378")]
			public uint SpinCount
			{
				[Token(Token = "0x60061AF")]
				[Address(RVA = "0xADDA", Offset = "0xADDA", VA = "0xADDA")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x17001379 RID: 4985
			// (get) Token: 0x060061B0 RID: 25008 RVA: 0x00011FB8 File Offset: 0x000101B8
			[Token(Token = "0x17001379")]
			public uint FreeAttemptsCount
			{
				[Token(Token = "0x60061B0")]
				[Address(RVA = "0xADDB", Offset = "0xADDB", VA = "0xADDB")]
				[CompilerGenerated]
				get
				{
					return 0U;
				}
			}

			// Token: 0x060061B1 RID: 25009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60061B1")]
			[Address(RVA = "0xADDC", Offset = "0xADDC", VA = "0xADDC")]
			public SlotMachineSpinEventArgs(App app, IGame game, SlotMachineType slotMachineType, uint spinCount, uint freeAttemptsCount)
			{
			}
		}
	}
}

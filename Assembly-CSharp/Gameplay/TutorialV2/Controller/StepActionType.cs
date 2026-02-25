using System;
using Il2CppDummyDll;

namespace Gameplay.TutorialV2.Controller
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	[Flags]
	public enum StepActionType
	{
		// Token: 0x04000D96 RID: 3478
		[Token(Token = "0x4000D96")]
		None = 0,
		// Token: 0x04000D97 RID: 3479
		[Token(Token = "0x4000D97")]
		Dialogue = 1,
		// Token: 0x04000D98 RID: 3480
		[Token(Token = "0x4000D98")]
		Pointer = 2,
		// Token: 0x04000D99 RID: 3481
		[Token(Token = "0x4000D99")]
		StartCombat = 4,
		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		ChangeLayout = 8,
		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		CombatOverlap = 16,
		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		Scale = 32,
		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		start_game = 4096,
		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		first_battle = 8192,
		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		first_battle_win = 16384,
		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		user_profile_basic = 32768,
		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		first_building = 65536,
		// Token: 0x04000DA2 RID: 3490
		[Token(Token = "0x4000DA2")]
		learn_boosters = 131072,
		// Token: 0x04000DA3 RID: 3491
		[Token(Token = "0x4000DA3")]
		second_battle = 262144,
		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		new_chest = 524288,
		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		next_improvement = 1048576,
		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		first_task_start = 2097152,
		// Token: 0x04000DA7 RID: 3495
		[Token(Token = "0x4000DA7")]
		Step01 = 16777216,
		// Token: 0x04000DA8 RID: 3496
		[Token(Token = "0x4000DA8")]
		Step02 = 33554432,
		// Token: 0x04000DA9 RID: 3497
		[Token(Token = "0x4000DA9")]
		Step03 = 50331648,
		// Token: 0x04000DAA RID: 3498
		[Token(Token = "0x4000DAA")]
		Step04 = 67108864,
		// Token: 0x04000DAB RID: 3499
		[Token(Token = "0x4000DAB")]
		Step05 = 83886080,
		// Token: 0x04000DAC RID: 3500
		[Token(Token = "0x4000DAC")]
		Step06 = 100663296,
		// Token: 0x04000DAD RID: 3501
		[Token(Token = "0x4000DAD")]
		Step07 = 117440512,
		// Token: 0x04000DAE RID: 3502
		[Token(Token = "0x4000DAE")]
		Step08 = 134217728,
		// Token: 0x04000DAF RID: 3503
		[Token(Token = "0x4000DAF")]
		Step09 = 150994944,
		// Token: 0x04000DB0 RID: 3504
		[Token(Token = "0x4000DB0")]
		Step10 = 167772160,
		// Token: 0x04000DB1 RID: 3505
		[Token(Token = "0x4000DB1")]
		Step11 = 184549376,
		// Token: 0x04000DB2 RID: 3506
		[Token(Token = "0x4000DB2")]
		Step12 = 201326592,
		// Token: 0x04000DB3 RID: 3507
		[Token(Token = "0x4000DB3")]
		Step13 = 218103808,
		// Token: 0x04000DB4 RID: 3508
		[Token(Token = "0x4000DB4")]
		Step14 = 234881024,
		// Token: 0x04000DB5 RID: 3509
		[Token(Token = "0x4000DB5")]
		Step15 = 251658240,
		// Token: 0x04000DB6 RID: 3510
		[Token(Token = "0x4000DB6")]
		Step16 = 268435456,
		// Token: 0x04000DB7 RID: 3511
		[Token(Token = "0x4000DB7")]
		Step17 = 285212672,
		// Token: 0x04000DB8 RID: 3512
		[Token(Token = "0x4000DB8")]
		Step18 = 301989888,
		// Token: 0x04000DB9 RID: 3513
		[Token(Token = "0x4000DB9")]
		Step19 = 318767104,
		// Token: 0x04000DBA RID: 3514
		[Token(Token = "0x4000DBA")]
		Step20 = 335544320,
		// Token: 0x04000DBB RID: 3515
		[Token(Token = "0x4000DBB")]
		Step21 = 352321536,
		// Token: 0x04000DBC RID: 3516
		[Token(Token = "0x4000DBC")]
		Step22 = 369098752,
		// Token: 0x04000DBD RID: 3517
		[Token(Token = "0x4000DBD")]
		Step23 = 385875968,
		// Token: 0x04000DBE RID: 3518
		[Token(Token = "0x4000DBE")]
		Step24 = 402653184,
		// Token: 0x04000DBF RID: 3519
		[Token(Token = "0x4000DBF")]
		Step25 = 419430400,
		// Token: 0x04000DC0 RID: 3520
		[Token(Token = "0x4000DC0")]
		Step26 = 436207616,
		// Token: 0x04000DC1 RID: 3521
		[Token(Token = "0x4000DC1")]
		Step27 = 452984832,
		// Token: 0x04000DC2 RID: 3522
		[Token(Token = "0x4000DC2")]
		Step28 = 469762048,
		// Token: 0x04000DC3 RID: 3523
		[Token(Token = "0x4000DC3")]
		Step29 = 486539264,
		// Token: 0x04000DC4 RID: 3524
		[Token(Token = "0x4000DC4")]
		Step30 = 503316480,
		// Token: 0x04000DC5 RID: 3525
		[Token(Token = "0x4000DC5")]
		Step31 = 520093696,
		// Token: 0x04000DC6 RID: 3526
		[Token(Token = "0x4000DC6")]
		Step32 = 536870912,
		// Token: 0x04000DC7 RID: 3527
		[Token(Token = "0x4000DC7")]
		StageMask = 16773120,
		// Token: 0x04000DC8 RID: 3528
		[Token(Token = "0x4000DC8")]
		StepMask = 2130706432
	}
}

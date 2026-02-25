using System;
using Gameplay.Combat.Model;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Combat.View.Players.Pet
{
	// Token: 0x02000955 RID: 2389
	[Token(Token = "0x2000955")]
	public interface IPetView
	{
		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x060038A8 RID: 14504
		// (set) Token: 0x060038A9 RID: 14505
		[Token(Token = "0x17000B2B")]
		UserSkillDic CurrentHealUserSkillDic { [Token(Token = "0x60038A8")] get; [Token(Token = "0x60038A9")] set; }

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x060038AA RID: 14506
		// (set) Token: 0x060038AB RID: 14507
		[Token(Token = "0x17000B2C")]
		bool Visible { [Token(Token = "0x60038AA")] get; [Token(Token = "0x60038AB")] set; }

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x060038AC RID: 14508
		// (set) Token: 0x060038AD RID: 14509
		[Token(Token = "0x17000B2D")]
		PetData Data { [Token(Token = "0x60038AC")] get; [Token(Token = "0x60038AD")] set; }

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x060038AE RID: 14510
		[Token(Token = "0x17000B2E")]
		bool IsDead { [Token(Token = "0x60038AE")] get; }

		// Token: 0x060038AF RID: 14511
		[Token(Token = "0x60038AF")]
		void UpdateHealth(float delay);
	}
}

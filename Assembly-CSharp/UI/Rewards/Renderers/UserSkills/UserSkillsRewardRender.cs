using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers.UserSkills
{
	// Token: 0x020001AF RID: 431
	[Token(Token = "0x20001AF")]
	public class UserSkillsRewardRender : AbstractRewardRender
	{
		// Token: 0x06000B9D RID: 2973 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9D")]
		[Address(RVA = "0x5EB6", Offset = "0x5EB6", VA = "0x5EB6", Slot = "8")]
		protected override void HandleRewardChanged()
		{
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9E")]
		[Address(RVA = "0x5EB7", Offset = "0x5EB7", VA = "0x5EB7")]
		public UserSkillsRewardRender()
		{
		}

		// Token: 0x04000566 RID: 1382
		[Token(Token = "0x4000566")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _skillsOwner;
	}
}

using System;
using Gameplay.Inventory.View.Info.InfoBox;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Rewards.Renderers.UserSkills
{
	// Token: 0x020001AE RID: 430
	[Token(Token = "0x20001AE")]
	[RequireComponent(typeof(TitleIconLoaderValueRow))]
	public class UserSkillRowRender : AbstractRewardRender
	{
		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06000B9B RID: 2971 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000183")]
		public TitleIconLoaderValueRow Row
		{
			[Token(Token = "0x6000B9B")]
			[Address(RVA = "0x5EB4", Offset = "0x5EB4", VA = "0x5EB4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B9C")]
		[Address(RVA = "0x5EB5", Offset = "0x5EB5", VA = "0x5EB5")]
		public UserSkillRowRender()
		{
		}

		// Token: 0x04000565 RID: 1381
		[Token(Token = "0x4000565")]
		[FieldOffset(Offset = "0x28")]
		private TitleIconLoaderValueRow _row;
	}
}

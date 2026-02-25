using System;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7E RID: 2942
	[Token(Token = "0x2000B7E")]
	public class BossSkillInfoView : SkillsInfoView
	{
		// Token: 0x17000E49 RID: 3657
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E49")]
		public string Description
		{
			[Token(Token = "0x6004773")]
			[Address(RVA = "0x1B57", Offset = "0x1B57", VA = "0x1B57")]
			set
			{
			}
		}

		// Token: 0x17000E4A RID: 3658
		// (set) Token: 0x06004774 RID: 18292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4A")]
		public string DominateCultDescription
		{
			[Token(Token = "0x6004774")]
			[Address(RVA = "0x1B5C", Offset = "0x1B5C", VA = "0x1B5C")]
			set
			{
			}
		}

		// Token: 0x06004775 RID: 18293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004775")]
		[Address(RVA = "0x9605", Offset = "0x9605", VA = "0x9605")]
		public BossSkillInfoView()
		{
		}

		// Token: 0x0400273E RID: 10046
		[Token(Token = "0x400273E")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _descLabel;

		// Token: 0x0400273F RID: 10047
		[Token(Token = "0x400273F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TextMeshProUGUI _dominateCultLabel;
	}
}

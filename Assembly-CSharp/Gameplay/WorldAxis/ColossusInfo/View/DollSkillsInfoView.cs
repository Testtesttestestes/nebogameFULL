using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Gameplay.UserInfo.View;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Gameplay.WorldAxis.ColossusInfo.View
{
	// Token: 0x02000324 RID: 804
	[Token(Token = "0x2000324")]
	public class DollSkillsInfoView : BaseInfoBox
	{
		// Token: 0x06001282 RID: 4738 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x647C", Offset = "0x647C", VA = "0x647C")]
		public void Init(SkillCollection dollSkills, StoneDic stone, HashSet<uint> customSkillIds)
		{
		}

		// Token: 0x06001283 RID: 4739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001283")]
		[Address(RVA = "0x647D", Offset = "0x647D", VA = "0x647D", Slot = "5")]
		public override void UpdateInfo()
		{
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001284")]
		[Address(RVA = "0x647E", Offset = "0x647E", VA = "0x647E")]
		public DollSkillsInfoView()
		{
		}

		// Token: 0x040009FF RID: 2559
		[Token(Token = "0x40009FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DollSkillRow _skillPrefab;

		// Token: 0x04000A00 RID: 2560
		[Token(Token = "0x4000A00")]
		[FieldOffset(Offset = "0x1C")]
		private StoneDic _stone;

		// Token: 0x04000A01 RID: 2561
		[Token(Token = "0x4000A01")]
		[FieldOffset(Offset = "0x20")]
		private SkillCollection _dollSkills;

		// Token: 0x04000A02 RID: 2562
		[Token(Token = "0x4000A02")]
		[FieldOffset(Offset = "0x24")]
		private HashSet<uint> _customSkillIds;
	}
}

using System;
using System.Collections.Generic;
using Core.Data.Skills;
using Il2CppDummyDll;
using UnityEngine;
using Utils.Cache;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B79 RID: 2937
	[Token(Token = "0x2000B79")]
	public class BossAttackSkillBonusView : MonoBehaviour
	{
		// Token: 0x06004757 RID: 18263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004757")]
		[Address(RVA = "0x95EB", Offset = "0x95EB", VA = "0x95EB")]
		private void Awake()
		{
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E38")]
		public Skills Skills
		{
			[Token(Token = "0x6004758")]
			[Address(RVA = "0x95EC", Offset = "0x95EC", VA = "0x95EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004759")]
			[Address(RVA = "0x95ED", Offset = "0x95ED", VA = "0x95ED")]
			set
			{
			}
		}

		// Token: 0x0600475A RID: 18266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600475A")]
		[Address(RVA = "0x95EE", Offset = "0x95EE", VA = "0x95EE")]
		public BossAttackSkillBonusView()
		{
		}

		// Token: 0x04002723 RID: 10019
		[Token(Token = "0x4002723")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04002724 RID: 10020
		[Token(Token = "0x4002724")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SkillIconValue _skillIconValuePrefab;

		// Token: 0x04002725 RID: 10021
		[Token(Token = "0x4002725")]
		[FieldOffset(Offset = "0x18")]
		private GameObjectPool<SkillIconValue> _pool;

		// Token: 0x04002726 RID: 10022
		[Token(Token = "0x4002726")]
		[FieldOffset(Offset = "0x1C")]
		private List<SkillIconValue> _currentViews;

		// Token: 0x04002727 RID: 10023
		[Token(Token = "0x4002727")]
		[FieldOffset(Offset = "0x20")]
		private Skills _skills;
	}
}

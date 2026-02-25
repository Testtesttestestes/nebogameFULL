using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Protocol.Consts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Combat.View.Players
{
	// Token: 0x02000948 RID: 2376
	[Token(Token = "0x2000948")]
	public class CombatPlayerLevelView : MonoBehaviour
	{
		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x0000B3B8 File Offset: 0x000095B8
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B14")]
		public bool IsPremiumExp
		{
			[Token(Token = "0x6003833")]
			[Address(RVA = "0x87EA", Offset = "0x87EA", VA = "0x87EA")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003834")]
			[Address(RVA = "0x87EB", Offset = "0x87EB", VA = "0x87EB")]
			set
			{
			}
		}

		// Token: 0x06003835 RID: 14389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003835")]
		[Address(RVA = "0x87EC", Offset = "0x87EC", VA = "0x87EC")]
		private void HandleIsPreminumExpChanged(bool from, bool to)
		{
		}

		// Token: 0x06003836 RID: 14390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003836")]
		[Address(RVA = "0x87ED", Offset = "0x87ED", VA = "0x87ED")]
		public void SetValue(uint value)
		{
		}

		// Token: 0x06003837 RID: 14391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003837")]
		[Address(RVA = "0x87EE", Offset = "0x87EE", VA = "0x87EE")]
		public void SetRank(RankTypes value)
		{
		}

		// Token: 0x06003838 RID: 14392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003838")]
		[Address(RVA = "0x87EF", Offset = "0x87EF", VA = "0x87EF")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x06003839 RID: 14393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003839")]
		[Address(RVA = "0x87F0", Offset = "0x87F0", VA = "0x87F0")]
		public CombatPlayerLevelView()
		{
		}

		// Token: 0x04001F13 RID: 7955
		[Token(Token = "0x4001F13")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Color32 _premiumExpColor;

		// Token: 0x04001F14 RID: 7956
		[Token(Token = "0x4001F14")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Color32 _expColor;

		// Token: 0x04001F15 RID: 7957
		[Token(Token = "0x4001F15")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04001F16 RID: 7958
		[Token(Token = "0x4001F16")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private List<RankImages> _rankImages;

		// Token: 0x04001F17 RID: 7959
		[Token(Token = "0x4001F17")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _expIndicator;

		// Token: 0x04001F18 RID: 7960
		[Token(Token = "0x4001F18")]
		[FieldOffset(Offset = "0x24")]
		private bool _isPremiumExp;
	}
}

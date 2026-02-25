using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public class LevelView : MonoBehaviour
	{
		// Token: 0x06001671 RID: 5745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001671")]
		[Address(RVA = "0x6832", Offset = "0x6832", VA = "0x6832")]
		public void SetExperienceProgress(float value)
		{
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001672 RID: 5746 RVA: 0x00005490 File Offset: 0x00003690
		// (set) Token: 0x06001673 RID: 5747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003BE")]
		public bool IsPremiumExp
		{
			[Token(Token = "0x6001672")]
			[Address(RVA = "0x6833", Offset = "0x6833", VA = "0x6833")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001673")]
			[Address(RVA = "0x6834", Offset = "0x6834", VA = "0x6834")]
			set
			{
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001674")]
		[Address(RVA = "0x6835", Offset = "0x6835", VA = "0x6835")]
		public void SetValue(uint value)
		{
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001675")]
		[Address(RVA = "0x6836", Offset = "0x6836", VA = "0x6836")]
		private void HandleIsPremiumExpChanged(bool from, bool to)
		{
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001676")]
		[Address(RVA = "0x6837", Offset = "0x6837", VA = "0x6837")]
		public LevelView()
		{
		}

		// Token: 0x04000BCA RID: 3018
		[Token(Token = "0x4000BCA")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Sprite _premiumExp;

		// Token: 0x04000BCB RID: 3019
		[Token(Token = "0x4000BCB")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Sprite _defaultExp;

		// Token: 0x04000BCC RID: 3020
		[Token(Token = "0x4000BCC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _valueField;

		// Token: 0x04000BCD RID: 3021
		[Token(Token = "0x4000BCD")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _expIndicator;

		// Token: 0x04000BCE RID: 3022
		[Token(Token = "0x4000BCE")]
		[FieldOffset(Offset = "0x20")]
		private bool _isPremiumExp;
	}
}

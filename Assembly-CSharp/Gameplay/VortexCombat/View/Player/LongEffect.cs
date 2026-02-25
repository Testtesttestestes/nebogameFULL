using System;
using System.Collections.Generic;
using Core.Data.Effect;
using Il2CppDummyDll;
using TMPro;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.VortexCombat.View.Player
{
	// Token: 0x020003AC RID: 940
	[Token(Token = "0x20003AC")]
	public class LongEffect : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x1700039F RID: 927
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700039F")]
		public List<EffectData> Effects
		{
			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x67AE", Offset = "0x67AE", VA = "0x67AE")]
			get
			{
				return null;
			}
			[Token(Token = "0x60015ED")]
			[Address(RVA = "0x67AF", Offset = "0x67AF", VA = "0x67AF")]
			set
			{
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015EE")]
		[Address(RVA = "0x67B0", Offset = "0x67B0", VA = "0x67B0")]
		private void HandleEffectsChanged()
		{
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60015EF")]
		[Address(RVA = "0x67B1", Offset = "0x67B1", VA = "0x67B1", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x060015F0 RID: 5616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60015F0")]
		[Address(RVA = "0x67B2", Offset = "0x67B2", VA = "0x67B2")]
		public LongEffect()
		{
		}

		// Token: 0x04000B9F RID: 2975
		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _count;

		// Token: 0x04000BA0 RID: 2976
		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x14")]
		private List<EffectData> _effects;
	}
}

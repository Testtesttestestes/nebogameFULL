using System;
using Core.Data.Effect;
using Il2CppDummyDll;
using UI.ToolTip.Implementations.View.Combat;
using UnityEngine;

namespace Gameplay.Combat.View.Players.LongEffects
{
	// Token: 0x0200095B RID: 2395
	[Token(Token = "0x200095B")]
	public class LongEffectWidget : MonoBehaviour
	{
		// Token: 0x060038CC RID: 14540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CC")]
		[Address(RVA = "0x886A", Offset = "0x886A", VA = "0x886A")]
		public void SetData(EffectData data)
		{
		}

		// Token: 0x060038CD RID: 14541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60038CD")]
		[Address(RVA = "0x886B", Offset = "0x886B", VA = "0x886B")]
		public LongEffectWidget()
		{
		}

		// Token: 0x04001F5D RID: 8029
		[Token(Token = "0x4001F5D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private CombatLongEffectToolTipItemView _view;
	}
}

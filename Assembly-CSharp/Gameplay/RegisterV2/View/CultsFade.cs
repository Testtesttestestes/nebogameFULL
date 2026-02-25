using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x02000558 RID: 1368
	[Token(Token = "0x2000558")]
	public class CultsFade : MonoBehaviour
	{
		// Token: 0x060020F2 RID: 8434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x7255", Offset = "0x7255", VA = "0x7255")]
		private void OnDestroy()
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x7256", Offset = "0x7256", VA = "0x7256")]
		private void Start()
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x7257", Offset = "0x7257", VA = "0x7257")]
		private void HandleStateChangedEvent(SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState fromState, SpellsAndCultDescriptionPanel.SpellsAndCultDescriptionPanelState toState)
		{
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F5")]
		[Address(RVA = "0x7258", Offset = "0x7258", VA = "0x7258")]
		public void Validate()
		{
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F6")]
		[Address(RVA = "0x7259", Offset = "0x7259", VA = "0x7259")]
		public CultsFade()
		{
		}

		// Token: 0x040011F9 RID: 4601
		[Token(Token = "0x40011F9")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Transform _cultsLementsOwner;

		// Token: 0x040011FA RID: 4602
		[Token(Token = "0x40011FA")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private SpellsAndCultDescriptionPanel _panel;
	}
}

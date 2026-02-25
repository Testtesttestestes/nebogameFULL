using System;
using Gameplay.Competition.Control;
using Gameplay.Competition.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;

namespace Gameplay.Competition.View.Sections
{
	// Token: 0x020008E1 RID: 2273
	[Token(Token = "0x20008E1")]
	[AddComponentMenu("Competition/View/Sections/SectionContainer")]
	public class SectionContainer : MonoBehaviourWithStates<Sections>
	{
		// Token: 0x0600357A RID: 13690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357A")]
		[Address(RVA = "0x8588", Offset = "0x8588", VA = "0x8588")]
		private void Awake()
		{
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357B")]
		[Address(RVA = "0x8589", Offset = "0x8589", VA = "0x8589")]
		public void Init(CompetitionController controller)
		{
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600357C")]
		[Address(RVA = "0x858A", Offset = "0x858A", VA = "0x858A")]
		public SectionContainer()
		{
		}

		// Token: 0x04001D41 RID: 7489
		[Token(Token = "0x4001D41")]
		[FieldOffset(Offset = "0x19")]
		private bool _isInit;
	}
}

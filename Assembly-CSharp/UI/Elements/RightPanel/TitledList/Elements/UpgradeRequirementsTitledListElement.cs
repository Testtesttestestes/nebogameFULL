using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements;
using UnityEngine;

namespace UI.Elements.RightPanel.TitledList.Elements
{
	// Token: 0x02000210 RID: 528
	[Token(Token = "0x2000210")]
	public class UpgradeRequirementsTitledListElement : BaseTitledListElement<UpgradeRequirementsTitledListElementArgs>
	{
		// Token: 0x06000D4C RID: 3404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x602F", Offset = "0x602F", VA = "0x602F", Slot = "6")]
		protected override void OnInit(UpgradeRequirementsTitledListElementArgs args)
		{
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4D")]
		[Address(RVA = "0x6030", Offset = "0x6030", VA = "0x6030")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D4E")]
		[Address(RVA = "0x6031", Offset = "0x6031", VA = "0x6031")]
		public UpgradeRequirementsTitledListElement()
		{
		}

		// Token: 0x04000692 RID: 1682
		[Token(Token = "0x4000692")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private RectTransform _requirementsContainer;

		// Token: 0x04000693 RID: 1683
		[Token(Token = "0x4000693")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private UpgradeRequirementElement _requirementElementPrefab;

		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		[FieldOffset(Offset = "0x18")]
		private List<UpgradeRequirementElement> _instancedElements;
	}
}

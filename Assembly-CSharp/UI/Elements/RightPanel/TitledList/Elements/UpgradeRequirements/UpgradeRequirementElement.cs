using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Elements.RightPanel.TitledList.Elements.UpgradeRequirements
{
	// Token: 0x02000212 RID: 530
	[Token(Token = "0x2000212")]
	public class UpgradeRequirementElement : MonoBehaviour
	{
		// Token: 0x06000D50 RID: 3408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D50")]
		[Address(RVA = "0x6033", Offset = "0x6033", VA = "0x6033")]
		public void Init(UpgradeRequirementElementArgs args)
		{
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D51")]
		[Address(RVA = "0x6034", Offset = "0x6034", VA = "0x6034")]
		public UpgradeRequirementElement()
		{
		}

		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Image _collected;

		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _requirementText;
	}
}

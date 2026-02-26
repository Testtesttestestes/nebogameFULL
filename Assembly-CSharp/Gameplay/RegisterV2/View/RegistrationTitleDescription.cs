using System;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Filters.GenericFilter;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.RegisterV2.View
{
	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	public class RegistrationTitleDescription : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x1700060A RID: 1546
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060A")]
		public TextMeshProUGUI Title
		{
			[Token(Token = "0x6002100")]
			[Address(RVA = "0x7262", Offset = "0x7262", VA = "0x7262")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700060B RID: 1547
		// (get) Token: 0x06002101 RID: 8449 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700060B")]
		public TextMeshProUGUI Description
		{
			[Token(Token = "0x6002101")]
			[Address(RVA = "0x7263", Offset = "0x7263", VA = "0x7263")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002102")]
		[Address(RVA = "0x7264", Offset = "0x7264", VA = "0x7264", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002103 RID: 8451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002103")]
		[Address(RVA = "0x7265", Offset = "0x7265", VA = "0x7265")]
		public RegistrationTitleDescription()
		{
		}

		// Token: 0x04001204 RID: 4612
		[Token(Token = "0x4001204")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04001205 RID: 4613
		[Token(Token = "0x4001205")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x04001206 RID: 4614
		[Token(Token = "0x4001206")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DeselectableGenericFilterView _spells;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_Description ---
		void Gameplay_RegisterV2_View_RegistrationTitleDescription__get_Description
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  UI_Elements_Filters_GenericFilter_GenericFilterView__SelectElement
		            (*(undefined4 *)(param1 + 0x18),0xffffffff,0);
		  return;
		}
		*/

}

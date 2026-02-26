using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000349 RID: 841
	[Token(Token = "0x2000349")]
	public class EquipmentInfoBox : MonoBehaviour
	{
		// Token: 0x06001349 RID: 4937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001349")]
		[Address(RVA = "0x653A", Offset = "0x653A", VA = "0x653A")]
		public void Init(IList<ArtifactData> artifacts, UserData user)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_WorldAxis_ClanEquipment_View_EquipmentInfoBox__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58c39 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    DAT_ram_00a58c39 = '\x01';
		  }
		  iVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		  *(undefined4 *)(iVar1 + 0x10) = 5;
		  *(undefined4 *)(param1 + 0x24) = 0;
		  *(int *)(param1 + 0x20) = iVar1;
		  *(undefined4 *)(param1 + 0x1c) = 0;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600134A")]
		[Address(RVA = "0x653B", Offset = "0x653B", VA = "0x653B")]
		public EquipmentInfoBox()
		{
		}

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[FieldOffset(Offset = "0x1C")]
		private ArtifactView.ArtifactViewArgs _customArgs;
	}
}

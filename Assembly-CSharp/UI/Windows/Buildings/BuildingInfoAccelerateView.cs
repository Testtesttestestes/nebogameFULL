using System;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Buttons;
using UI.Elements.ProgressBars;
using UnityEngine;
using UnityEngine.UI;

namespace UI.Windows.Buildings
{
	// Token: 0x020002A9 RID: 681
	[Token(Token = "0x20002A9")]
	public class BuildingInfoAccelerateView : MonoBehaviour
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000244")]
		public Button CancelButton
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x620C", Offset = "0x620C", VA = "0x620C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06001003 RID: 4099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000245")]
		public Button AccelerateButton
		{
			[Token(Token = "0x6001003")]
			[Address(RVA = "0x620D", Offset = "0x620D", VA = "0x620D")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x620E", Offset = "0x620E", VA = "0x620E")]
		public void SetData(BaseBuildingData buildingData, UserData ownerUserData, UserData loggedUser)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x620F", Offset = "0x620F", VA = "0x620F")]
		public BuildingInfoAccelerateView()
		{
		}

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _titleLabel;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _descLabel;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ButtonWithCost _accelerateButton;

		// Token: 0x0400082A RID: 2090
		[Token(Token = "0x400082A")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Button _cancelButton;

		// Token: 0x0400082B RID: 2091
		[Token(Token = "0x400082B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ProgressBarWithTimer _upgradeProgress;

		// Token: 0x0400082C RID: 2092
		[Token(Token = "0x400082C")]
		[FieldOffset(Offset = "0x24")]
		private BaseBuildingData _buildingData;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_AccelerateButton ---
		void UI_Windows_Buildings_BuildingInfoAccelerateView__get_AccelerateButton
		               (int param1,int *param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 in_register_20000014;
		  undefined8 uVar1;
		  undefined4 in_register_20000024;
		  undefined8 uVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *param2_00;
		  float fVar8;
		  int *piVar9;
		  int iVar10;
		  undefined4 uVar11;
		  longlong lVar12;
		  uint uVar13;
		  longlong param3_00;
		  int local_4;
		  
		  if (DAT_ram_00a58a8e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3704);
		    DAT_ram_00a58a8e = '\x01';
		  }
		  *(int **)(param1 + 0x24) = param2;
		  if (param2 != (int *)0x0) {
		    uVar1 = CONCAT44(in_register_20000014,*(undefined4 *)(*param2 + 0x124));
		    iVar3 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x120) * 4))(param2,uVar1);
		    if (iVar3 == 0) {
		      uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      iVar3 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding
		                        (*(undefined4 *)(param1 + 0x24),0);
		      iVar3 = iVar3 + 1;
		      local_4 = iVar3;
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar10 = *piVar9;
		      if (*(ushort *)(iVar10 + 0xb6) != 0) {
		        uVar13 = 0;
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8)) {
		            puVar4 = (uint *)(*(int *)(*(int *)(iVar10 + 0x58) + uVar13 * 8 + 4) * 8 + iVar10 +
		                             0x178);
		            goto code_r0x80f6bf7b;
		          }
		          uVar13 = uVar13 + 1;
		        } while (*(ushort *)(iVar10 + 0xb6) != uVar13);
		      }
		      puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f6bf7b:
		      uVar1 = CONCAT44(uVar11,puVar4[1]);
		      uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,uVar1);
		      uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar5 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar5,0);
		      uVar1 = CONCAT44(uVar11,iVar3);
		      uVar2 = CONCAT44(in_register_20000024,uVar5);
		      uVar6 = (**(code **)((ulonglong)*(uint *)(*param2 + 0x130) * 4))
		                        (param2,uVar1,uVar2,*(undefined4 *)(*param2 + 0x134));
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      piVar9 = *(int **)(param1 + 0x10);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar7 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_3704,1,0,1,0,0,0,0);
		      param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,1);
		      iVar3 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_4,0);
		      if ((iVar3 != 0) &&
		         (iVar10 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar10 == 0)) {
		        uVar11 = func_ii_1083();
		        func_ii_1050(uVar11,0);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      param2_00[4] = iVar3;
		      uVar7 = Locale__GetText(uVar7,param2_00,0);
		      iVar3 = *piVar9;
		      uVar1 = CONCAT44(uVar11,uVar7);
		      uVar2 = CONCAT44(uVar5,*(undefined4 *)(iVar3 + 0x2d4));
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))(piVar9,uVar1,uVar2);
		      uVar5 = (undefined4)((ulonglong)uVar2 >> 0x20);
		      piVar9 = *(int **)(param1 + 0x14);
		      iVar3 = **(int **)(param1 + 0x24);
		      uVar1 = CONCAT44((int)((ulonglong)uVar1 >> 0x20),*(undefined4 *)(iVar3 + 0xfc));
		      uVar7 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf8) * 4))(*(int **)(param1 + 0x24),uVar1);
		      uVar11 = (undefined4)((ulonglong)uVar1 >> 0x20);
		      uVar6 = Core_GameLocalization__GetTranslation(uVar7,uVar6,0);
		      iVar3 = *piVar9;
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		                (piVar9,CONCAT44(uVar11,uVar6),CONCAT44(uVar5,*(undefined4 *)(iVar3 + 0x2d4)));
		      uVar11 = *(undefined4 *)(param1 + 0x20);
		      iVar3 = **(int **)(param1 + 0x24);
		      uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x118) * 4))
		                        (*(int **)(param1 + 0x24),*(undefined4 *)(iVar3 + 0x11c));
		      fVar8 = func_ii_7103(*(undefined4 *)(*(int *)(param1 + 0x24) + 0x14),0);
		      if (fVar8 < 1.8446744e+19 && 0.0 <= fVar8) {
		        lVar12 = (longlong)fVar8;
		      }
		      else {
		        lVar12 = 0;
		      }
		      if (ABS(fVar8) < 9.223372e+18) {
		        param3_00 = (longlong)fVar8;
		      }
		      else {
		        param3_00 = -0x8000000000000000;
		      }
		      if (0.0 <= fVar8) {
		        param3_00 = lVar12;
		      }
		      UI_Elements_ProgressBars_ProgressBarWithTimer__TimerComplete(uVar11,uVar1,param3_00,0);
		      uVar5 = *(undefined4 *)(*(int *)(param1 + 0x18) + 0xb8);
		      uVar11 = Gameplay_World_Model_BaseBuildingData__GetUpgradeRequirementsProvider
		                         (*(undefined4 *)(param1 + 0x24),0);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      uVar11 = Core_Money_Money__op_Explicit(uVar11,0);
		      UI_Price_Price__SetColor(uVar5,param4,uVar11,0);
		    }
		  }
		  return;
		}
		*/

}

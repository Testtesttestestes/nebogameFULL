using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.World.View.Fx
{
	// Token: 0x0200035D RID: 861
	[Token(Token = "0x200035D")]
	public class SnowFxController : SnowFxControllerBase
	{
		// Token: 0x060013AA RID: 5034 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AA")]
		[Address(RVA = "0x659A", Offset = "0x659A", VA = "0x659A", Slot = "4")]
		protected override void ValidateEnable(bool enable)
		{
		}

		// Token: 0x060013AB RID: 5035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60013AB")]
		[Address(RVA = "0x659B", Offset = "0x659B", VA = "0x659B")]
		public SnowFxController()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_World_View_Fx_SnowFxController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  undefined4 param1_01;
		  bool bVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a58c6d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Utils_LongTap_LongTapHandler_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_View_Fx_SnowFxControllerBase_ButtonClickHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_World_View_Fx_SnowFxControllerBase_LongTapOnLongTapEvent__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_22912);
		    DAT_ram_00a58c6d = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x80f91e19;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f91e19:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar4 = Core_Extensions_Dict_DictExt__GetLongParameter(uVar3,StringLiteral_22912,0);
		  iVar6 = *param1_00;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x148);
		        goto code_r0x80f91eb1;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x11);
		code_r0x80f91eb1:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  param1[9] = iVar6;
		  if (iVar4 != 0) {
		    Gameplay_World_View_Fx_SnowFxControllerBase__TrackCameraPosition(param1,puVar2);
		    param1_01 = *(undefined4 *)(param1[5] + 0xb4);
		    uVar3 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar3,param1,Method_Gameplay_World_View_Fx_SnowFxControllerBase_ButtonClickHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(param1_01,uVar3,0);
		    iVar4 = param1[6];
		    uVar3 = unnamed_function_1417(Utils_LongTap_LongTapHandler_TypeInfo);
		    Utils_LongTap___cctor
		              (uVar3,param1,
		               Method_Gameplay_World_View_Fx_SnowFxControllerBase_LongTapOnLongTapEvent__,0);
		    Utils_LongTap__remove_CancelLongTapEvent(iVar4,uVar3,0);
		    if ((char)param1[8] == '\0') {
		      bVar5 = true;
		    }
		    else {
		      Gameplay_World_View_Fx_SnowFxControllerBase__OnDestroy
		                (param1,(uint)*(byte *)((int)param1 + 0x21),iVar4);
		      bVar5 = (char)param1[8] == '\0';
		    }
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		              (param1,bVar5,*(undefined4 *)(*param1 + 0xe4));
		    return;
		  }
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,0,0);
		  return;
		}
		*/

		}

		// Token: 0x04000A94 RID: 2708
		[Token(Token = "0x4000A94")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ParticleSystem _buttonParticles;
	}
}

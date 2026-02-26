using System;
using Gameplay.Tournaments.Events;
using Gameplay.Tournaments.Model;
using Gameplay.Tournaments.View;
using Il2CppDummyDll;
using MVC;

namespace Gameplay.Tournaments.Controller
{
	// Token: 0x020004BE RID: 1214
	[Token(Token = "0x20004BE")]
	public class TournamentHistoryViewMediator : AbstractViewMediator<TournamentsModel, TournamentsEvents, TournamentsController, TournamentHistoryWindow>
	{
		// Token: 0x06001CB8 RID: 7352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CB8")]
		[Address(RVA = "0x6E37", Offset = "0x6E37", VA = "0x6E37")]
		public TournamentHistoryViewMediator(TournamentsModel model, TournamentsEvents events, TournamentsController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a58525 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow__set_View__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_NextButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_PrevButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_RulesButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a58525 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_RulesButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_NextButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_PrevButtonClickedEventHandler__
		               ,0);
		    UnityEngine_Events_UnityAction___ctor(uVar3,uVar1,0);
		  }
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x4c) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_RulesButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x50) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_NextButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x54) + 0xb4);
		    uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar1,param1,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator_PrevButtonClickedEventHandler__
		               ,0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar3,uVar1,0);
		    Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__RulesButtonClickedEventHandler
		              (param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x1700052F RID: 1327
		// (set) Token: 0x06001CB9 RID: 7353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700052F")]
		public override TournamentHistoryWindow View
		{
			[Token(Token = "0x6001CB9")]
			[Address(RVA = "0x6E38", Offset = "0x6E38", VA = "0x6E38", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBA")]
		[Address(RVA = "0x6E39", Offset = "0x6E39", VA = "0x6E39")]
		private void PrevButtonClickedEventHandler()
		{
		/* --- GHIDRA: PrevButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__PrevButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  *(int *)(param1 + 0x18) = *(int *)(param1 + 0x18) + 1;
		  Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__ValidateNextPrevButtons
		            (param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBB")]
		[Address(RVA = "0x6E3A", Offset = "0x6E3A", VA = "0x6E3A")]
		private void NextButtonClickedEventHandler()
		{
		/* --- GHIDRA: NextButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__NextButtonClickedEventHandler
		               (undefined4 param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *param1_00;
		  int iVar4;
		  
		  if (DAT_ram_00a58526 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19433);
		    Mono_Security_ASN1__get_Item(&StringLiteral_27811);
		    DAT_ram_00a58526 = '\x01';
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
		        goto code_r0x80f00404;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80f00404:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar3 = Core_Extensions_Dict_DictExt__GetResourceSetParameter(uVar3,StringLiteral_27811,0);
		  Core_ExternAppMethods__OpenPaymentWindow(uVar3,StringLiteral_19433,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBC")]
		[Address(RVA = "0x6E3B", Offset = "0x6E3B", VA = "0x6E3B")]
		private void RulesButtonClickedEventHandler()
		{
		/* --- GHIDRA: RulesButtonClickedEventHandler ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__RulesButtonClickedEventHandler
		               (int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  undefined8 in_i2q;
		  int iVar2;
		  undefined4 param4;
		  uint *puVar3;
		  undefined4 uVar4;
		  int iVar5;
		  undefined4 uVar6;
		  undefined4 *puVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 uVar10;
		  int *piVar11;
		  
		  uVar4 = (undefined4)((ulonglong)in_i2q >> 0x20);
		  if (DAT_ram_00a58527 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_Any_Fighter___);
		    Mono_Security_ASN1__get_Item(&System_Func_Fighter__bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Cache_User_IUserInfoWrapper_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_Fighter__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TnmRound__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c__Init_b__8_0__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo);
		    DAT_ram_00a58527 = '\x01';
		  }
		  iVar5 = *(int *)(param1[2] + 0x14);
		  uVar6 = *(undefined4 *)(iVar5 + 0x10);
		  if (*(int *)(Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo + 0x74) ==
		      0) {
		    func_ii_306000(Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo);
		  }
		  puVar7 = *(undefined4 **)
		            (Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo + 0x5c);
		  iVar8 = puVar7[1];
		  if (iVar8 == 0) {
		    if (*(int *)(Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo + 0x74)
		        == 0) {
		      func_ii_306000(Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo);
		      puVar7 = *(undefined4 **)
		                (Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo + 0x5c);
		    }
		    uVar9 = *puVar7;
		    iVar8 = unnamed_function_1417(System_Func_Fighter__bool__TypeInfo);
		    System_Collections_Generic_Dictionary_uint__object___GetEnumerator
		              (iVar8,uVar9,
		               Method_Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c__Init_b__8_0__
		               ,0);
		    *(int *)(*(int *)(Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo +
		                     0x5c) + 4) = iVar8;
		  }
		  uVar6 = Newtonsoft_Json_Utilities_ReflectionUtils__IsOverridenGenericMember
		                    (uVar6,iVar8,Method_System_Linq_Enumerable_Any_Fighter___);
		  *(char *)(param1 + 7) = (char)uVar6;
		  param1[6] = *(int *)(*(int *)(iVar5 + 0xc) + 0xc) + -1;
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  UI_Tabs_TabBar__HandleSelected(*(undefined4 *)(iVar8 + 0x40),*(undefined4 *)(param1[2] + 0x30),0);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_GameEvents_Model_GameEventData__get_ContainsArtifactRewards
		            (*(undefined4 *)(iVar8 + 0x40),0,0,0);
		  iVar8 = System_Collections_Generic_List_object___get_Item
		                    (*(undefined4 *)(param1[2] + 0xc),*(undefined4 *)(param1[2] + 0x18),
		                     Method_System_Collections_Generic_Dictionary_uint__TournamentData__get_Item__);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar9 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x10);
		  uVar6 = Core_Extensions_Dict_ThemeRatingKindDicExt__GetDescription(*(undefined4 *)(iVar8 + 8),0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar9,uVar6,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar6 = *(undefined4 *)(iVar8 + 0x14);
		  uVar9 = *(undefined4 *)(*(int *)(iVar2 + 0x3c) + 0x18);
		  uVar10 = *(undefined4 *)(iVar5 + 0x1c);
		  if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Money_Money_TypeInfo);
		  }
		  uVar10 = Core_Money_Money__op_Explicit(uVar10,0);
		  param4 = Core_Money_Money__op_Explicit(*(undefined4 *)(iVar5 + 0x18),0);
		  Gameplay_Tournaments_View_TournamentBank__Start
		            (uVar9,uVar6,uVar10,param4,*(undefined4 *)(iVar8 + 0x18),iVar8);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar8 = *(int *)(*(int *)(iVar8 + 0x3c) + 0x14);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar11 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar11;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x158);
		        goto code_r0x80efffc7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar11,Core_Gameplay_IGame_TypeInfo,0x13);
		code_r0x80efffc7:
		  iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar11,puVar3[1]);
		  uVar1 = 0;
		  uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0x20) + 0xc) + 0xc);
		  piVar11 = *(int **)(iVar2 + 0x14);
		  iVar2 = *piVar11;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Cache_User_IUserInfoWrapper_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f00059;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar11,Core_Cache_User_IUserInfoWrapper_TypeInfo,0);
		code_r0x80f00059:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar11,uVar6,CONCAT44(uVar4,puVar3[1]));
		  Gameplay_Rating_View_UserView__get_UserData(*(undefined4 *)(iVar8 + 0x10),uVar4,0);
		  uVar6 = *(undefined4 *)(iVar8 + 0x14);
		  uVar4 = Google_Protobuf_Collections_RepeatedField_object___GetEnumerator(uVar4,0);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar6,uVar4,0);
		  iVar8 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = *(int *)(*(int *)(iVar5 + 0x10) + 0xc);
		  Gameplay_Tournaments_View_TournamentHistoryInfoBox__get_Bank
		            (*(undefined4 *)(iVar8 + 0x3c),iVar2,
		             (ulonglong)*(uint *)(iVar5 + 0x14) - (longlong)iVar2,iVar2);
		  Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__ValidateNextPrevButtons
		            (param1,iVar2);
		  return;
		}
		*/

		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBD")]
		[Address(RVA = "0x6E3C", Offset = "0x6E3C", VA = "0x6E3C")]
		private void Init()
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__Init
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a58528 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TnmRound__get_Count__);
		    DAT_ram_00a58528 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_
		            (*(undefined4 *)(iVar1 + 0x50),
		             (uint)(param1[6] < *(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 0xc) + 0xc) + -1),0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  System_Linq_Enumerable__First_object_(*(undefined4 *)(iVar1 + 0x54),(uint)(0 < param1[6]),0);
		  return;
		}
		*/

		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBE")]
		[Address(RVA = "0x6E3D", Offset = "0x6E3D", VA = "0x6E3D")]
		private void ValidateNextPrevButtons()
		{
		/* --- GHIDRA: ValidateNextPrevButtons ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__ValidateNextPrevButtons
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  longlong lVar4;
		  int iVar5;
		  int iVar6;
		  undefined4 param2_00;
		  uint uVar7;
		  
		  uVar7 = 0;
		  if (DAT_ram_00a58529 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_TournamentsModel__TournamentsEvents__TournamentsController__TournamentHistoryWindow__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TnmRound__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_TnmRound__get_Item__);
		    DAT_ram_00a58529 = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  param2_00 = *(undefined4 *)(*(int *)(param1[2] + 0x14) + 0x10);
		  uVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(*(int *)(param1[2] + 0x14) + 0xc),param1[6],
		                     Method_Google_Protobuf_Collections_RepeatedField_TnmRound__get_Item__);
		  Gameplay_Tournaments_View_TournamentHistoryWindow__OnShow(uVar1,param2_00,uVar2,param1);
		  Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__Init(param1,param1);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar2 = *(undefined4 *)(iVar3 + 0x58);
		  uVar1 = Gameplay_Tournaments_Model_TournamentsModel__GetPlayerStatusLocalization
		                    (param1,*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 0xc) + 0xc) - param1[6],
		                     param1);
		  UnityEngine_Component__GetComponentInChildren_object_(uVar2,uVar1,0);
		  iVar5 = param1[6];
		  iVar6 = *(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 0xc) + 0xc);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar3 + 0x5c);
		  iVar6 = iVar6 + -1;
		  if ((iVar5 == iVar6) && (uVar7 = 0, (char)param1[7] != '\0')) {
		    lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                      (*(undefined4 *)(param1[2] + 8),0);
		    uVar7 = (uint)(lVar4 == *(longlong *)
		                             (*(int *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 0x20) + 0xc) +
		                                      0xc) + 0x10));
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar7,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = *(undefined4 *)(iVar3 + 0x60);
		  if (iVar5 == iVar6) {
		    if ((char)param1[7] == '\0') {
		      uVar7 = 0;
		    }
		    else {
		      lVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param1[2] + 8),0);
		      uVar7 = (uint)(lVar4 != *(longlong *)
		                               (*(int *)(*(int *)(*(int *)(*(int *)(param1[2] + 0x14) + 0x20) + 0xc)
		                                        + 0xc) + 0x10));
		    }
		  }
		  else {
		    uVar7 = 0;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,uVar7,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (*(undefined4 *)(*(int *)(iVar3 + 0x3c) + 0x14),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,(uint)(iVar5 == iVar6),0);
		  return;
		}
		*/

		}

		// Token: 0x06001CBF RID: 7359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001CBF")]
		[Address(RVA = "0x6E3E", Offset = "0x6E3E", VA = "0x6E3E")]
		private void UpdateView()
		{
		/* --- GHIDRA: UpdateView ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__UpdateView(undefined4 param1)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5852a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo);
		    DAT_ram_00a5852a = '\x01';
		  }
		  uVar1 = unnamed_function_1417
		                    (Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo);
		  **(undefined4 **)
		    (Gameplay_Tournaments_Controller_TournamentHistoryViewMediator___c_TypeInfo + 0x5c) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x04000FAE RID: 4014
		[Token(Token = "0x4000FAE")]
		[FieldOffset(Offset = "0x18")]
		private int _index;

		// Token: 0x04000FAF RID: 4015
		[Token(Token = "0x4000FAF")]
		[FieldOffset(Offset = "0x1C")]
		private bool _isPlayerParticipant;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_View ---
		void Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__set_View
		               (int param1,undefined4 param2)
		
		{
		  *(int *)(param1 + 0x18) = *(int *)(param1 + 0x18) + -1;
		  Gameplay_Tournaments_Controller_TournamentHistoryViewMediator__ValidateNextPrevButtons
		            (param1,param1);
		  return;
		}
		*/

}

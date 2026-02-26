using System;
using Gameplay.Clans.Office.Events;
using Gameplay.Clans.Office.Model;
using Gameplay.Clans.Office.View;
using Gameplay.World.Controller;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Clans;
using Protocol.Consts;
using Protocol.Rating;
using ServicesNamespace;
using Utils;

namespace Gameplay.Clans.Office.Controller
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	public class ClanOfficeController : AbstractController<ClanOfficeModel, ClanOfficeEvents>
	{
		// Token: 0x06003F40 RID: 16192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F40")]
		[Address(RVA = "0x8DFB", Offset = "0x8DFB", VA = "0x8DFB")]
		public ClanOfficeController(ClanOfficeModel model, ClanOfficeEvents events, IUserIslesWorldMovement userWorldMovement)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController___ctor
		               (int *param1,undefined4 param2,undefined4 param3,int param4,int param5,
		               undefined4 param6)
		
		{
		  uint uVar1;
		  int param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param1_01;
		  int *param1_02;
		  int iVar4;
		  
		  if (DAT_ram_00a58014 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestFirstClanVacanciesResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanVacanciesListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a58014 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Clans_ProtoGetClanVacanciesListCmd_TypeInfo);
		  Protocol_Clans_ProtoGetClanVacanciesListCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x20) = 0;
		  *(undefined4 *)(param1_00 + 0x14) = param3;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  if (param5 == 0) {
		    uVar3 = 0;
		  }
		  else {
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar3 = func_ii_6965(*(undefined4 *)(iVar4 + 8),0);
		  }
		  *(undefined4 *)(param1_00 + 0xc) = uVar3;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_02;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x140);
		        goto code_r0x80e9453d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e9453d:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param1_02,puVar2[1]);
		  *(undefined8 *)(param1_00 + 0x18) = *(undefined8 *)(*(int *)(iVar4 + 0x14) + 0x10);
		  if (param4 == 0) {
		    param4 = StringLiteral_5;
		  }
		  Protocol_Clans_ProtoGetClanVacanciesListCmd__get_Title(param1_00,param4,0);
		  uVar3 = ServicesNamespace_ClansService__GetShortClansInfo(param1[6],param1_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestFirstClanVacanciesResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar3,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F41")]
		[Address(RVA = "0x8DFC", Offset = "0x8DFC", VA = "0x8DFC")]
		public void RequestFirstClanVacancies(ClanRatingTypes ratingTypes, RatingPeriods ratingPeriods, string name, bool onlyAvailable)
		{
		/* --- GHIDRA: RequestFirstClanVacancies ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestFirstClanVacancies
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  uint uVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a58015 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo);
		    DAT_ram_00a58015 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Clans_Office_Model_ClanOfficeModel__GetTabBarItemData(param1_00,param1_01,param1);
		  uVar2 = param1_01[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = param1_01[6];
		  if (uVar2 < *(uint *)(iVar1 + 0x3c)) {
		    Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMaxPage(param1,param2_00,param1);
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    if (*(uint *)(iVar1 + 0x40) < param2_00) {
		      Gameplay_Clans_Office_Controller_ClanOfficeController__ValidatePages
		                (param1,param1_01[6],param1);
		    }
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1_01[6],*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F42")]
		[Address(RVA = "0x8DFD", Offset = "0x8DFD", VA = "0x8DFD")]
		private void RequestFirstClanVacanciesResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestFirstClanVacanciesResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestFirstClanVacanciesResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,int param5,
		               int param6,undefined4 param7)
		
		{
		  int param1_00;
		  int iVar1;
		  undefined4 param1_01;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a58016 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestAdditionalClanVacanciesResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanVacanciesListCmd_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_5);
		    DAT_ram_00a58016 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Protocol_Clans_ProtoGetClanVacanciesListCmd_TypeInfo);
		  Protocol_Clans_ProtoGetClanVacanciesListCmd__pb__Google_Protobuf_IMessage_get_Descriptor
		            (param1_00,0);
		  *(undefined4 *)(param1_00 + 0x20) = param4;
		  *(undefined4 *)(param1_00 + 0x14) = param3;
		  *(undefined4 *)(param1_00 + 0x10) = param2;
		  if (param6 == 0) {
		    uVar2 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = func_ii_6965(*(undefined4 *)(iVar1 + 8),0);
		  }
		  *(undefined4 *)(param1_00 + 0xc) = uVar2;
		  if (param5 == 0) {
		    param5 = StringLiteral_5;
		  }
		  Protocol_Clans_ProtoGetClanVacanciesListCmd__get_Title(param1_00,param5,0);
		  uVar2 = ServicesNamespace_ClansService__GetShortClansInfo(param1[6],param1_00,0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestAdditionalClanVacanciesResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar2,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F43")]
		[Address(RVA = "0x8DFE", Offset = "0x8DFE", VA = "0x8DFE")]
		public void RequestAdditionalClanVacancies(ClanRatingTypes ratingTypes, RatingPeriods ratingPeriods, uint pageNumber, string name, bool onlyAvailable)
		{
		/* --- GHIDRA: RequestAdditionalClanVacancies ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestAdditionalClanVacancies
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  uint uVar2;
		  uint param2_00;
		  
		  if (DAT_ram_00a58017 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ClanInRating__get_Count__);
		    DAT_ram_00a58017 = '\x01';
		  }
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) &&
		     (Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo != *param1_01)) {
		    System_Activator__CreateInstance(param1_01,Protocol_Clans_ProtoGetClanVacanciesListAns_TypeInfo)
		    ;
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (*(int *)(param1_01[3] + 0xc) != 0) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Clans_Office_Model_ClanOfficeModel__CreateClanVacancies(param1_00,param1_01,param1);
		    uVar2 = param1_01[6];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param2_00 = param1_01[6];
		    if (uVar2 < *(uint *)(iVar1 + 0x3c)) {
		      Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMaxPage(param1,param2_00,param1);
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      if (*(uint *)(iVar1 + 0x40) < param2_00) {
		        Gameplay_Clans_Office_Controller_ClanOfficeController__ValidatePages
		                  (param1,param1_01[6],param1);
		      }
		    }
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x18);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),param1_01[6],*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F44")]
		[Address(RVA = "0x8DFF", Offset = "0x8DFF", VA = "0x8DFF")]
		private void RequestAdditionalClanVacanciesResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestAdditionalClanVacanciesResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestAdditionalClanVacanciesResultHandler
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint uVar2;
		  uint param2_00;
		  
		  uVar2 = *(uint *)(param2 + 0x18);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  param2_00 = *(uint *)(param2 + 0x18);
		  if (uVar2 < *(uint *)(iVar1 + 0x3c)) {
		    Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMaxPage(param1,param2_00,param1);
		    return;
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (*(uint *)(iVar1 + 0x40) < param2_00) {
		    Gameplay_Clans_Office_Controller_ClanOfficeController__ValidatePages
		              (param1,*(undefined4 *)(param2 + 0x18),param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F45")]
		[Address(RVA = "0x8E00", Offset = "0x8E00", VA = "0x8E00")]
		private void ValidatePages(ProtoGetClanVacanciesListAns msg)
		{
		/* --- GHIDRA: ValidatePages ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__ValidatePages
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58018 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a58018 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar2 + 0x40) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (2 < (uint)(*(int *)(iVar2 + 0x40) - *(int *)(iVar2 + 0x3c))) {
		    uVar1 = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = (int *)System_Collections_Generic_List_object___get_Item
		                                 (uVar4,*(undefined4 *)(iVar2 + 0x3c),
		                                  Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                                 );
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e949ae;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80e949ae:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    System_Collections_Generic_List_Enumerator_uint___MoveNext
		              (param1_01,*(undefined4 *)(iVar2 + 0x3c),
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Remove__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x3c) = *(int *)(iVar2 + 0x3c) + 1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x28);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar4,0,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F46")]
		[Address(RVA = "0x8E01", Offset = "0x8E01", VA = "0x8E01")]
		private void HandleMaxPage(uint pageNumber)
		{
		/* --- GHIDRA: HandleMaxPage ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMaxPage
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a58019 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Remove__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		              );
		    DAT_ram_00a58019 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  *(undefined4 *)(iVar2 + 0x3c) = param2;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  if (2 < (uint)(*(int *)(iVar2 + 0x40) - *(int *)(iVar2 + 0x3c))) {
		    uVar1 = 0;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_00 = (int *)System_Collections_Generic_List_object___get_Item
		                                 (uVar4,*(undefined4 *)(iVar2 + 0x40),
		                                  Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___get_Item__
		                                 );
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		            == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar2 + *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e947e4;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,
		                                  System_Collections_Generic_ICollection_ClanInRatingListElement_ClanInRatingListElementArgs__TypeInfo
		                                  ,0);
		code_r0x80e947e4:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    param1_01 = *(undefined4 *)(iVar2 + 0x14);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    System_Collections_Generic_List_Enumerator_uint___MoveNext
		              (param1_01,*(undefined4 *)(iVar2 + 0x40),
		               Method_System_Collections_Generic_Dictionary_uint__IList_ClanInRatingListElement_ClanInRatingListElementArgs___Remove__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int *)(iVar2 + 0x40) = *(int *)(iVar2 + 0x40) + -1;
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x28);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar4,1,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F47")]
		[Address(RVA = "0x8E02", Offset = "0x8E02", VA = "0x8E02")]
		private void HandleMinPage(uint pageNumber)
		{
		/* --- GHIDRA: HandleMinPage ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__HandleMinPage
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  
		  if (DAT_ram_00a5801a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestJoinClanResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4289);
		    Mono_Security_ASN1__get_Item(&StringLiteral_4311);
		    DAT_ram_00a5801a = '\x01';
		  }
		  uVar3 = *(undefined4 *)(param2 + 0x1c);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  uVar2 = func_ii_6965(*(undefined4 *)(iVar1 + 8),0);
		  iVar1 = Gameplay_World_Model_ClanData__TryGetCultDic(uVar3,uVar2,0);
		  if (iVar1 != 0) {
		    uVar2 = ServicesNamespace_ClansService__GetClanVacanciesList
		                      (param1[6],*(undefined8 *)(*(int *)(*(int *)(param2 + 0x24) + 0xc) + 0x10),0);
		    uVar3 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar3,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_RequestJoinClanResultHandler__
		               ,0);
		    uVar2 = ServicesNamespace_MainService__GetUserStats
		                      (uVar2,uVar3,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar2,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    return;
		  }
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4311,1,0,1,0,0,0,0);
		  uVar3 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_4289,1,0,1,0,0,0,0);
		  UI_Windows_DialogWindow__Show(uVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x8E03", Offset = "0x8E03", VA = "0x8E03")]
		public void RequestJoinClan(ClanInRatingListElement.ClanInRatingListElementArgs args)
		{
		/* --- GHIDRA: RequestJoinClan ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestJoinClan
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  int *piVar4;
		  int iVar5;
		  int *param1_01;
		  int iVar6;
		  undefined4 param3_00;
		  undefined8 uVar7;
		  
		  if (DAT_ram_00a5801b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPutJoinRequestErrors___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo);
		    DAT_ram_00a5801b = '\x01';
		  }
		  piVar4 = *(int **)(param2 + 0x20);
		  if ((piVar4 != (int *)0x0) && (Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo != *piVar4)) {
		    System_Activator__CreateInstance(piVar4,Protocol_Clans_ProtoPutRequestForJoinAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar5 = piVar4[4];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_Clans_ExpectedPutJoinRequestErrors_ExpectedPutJoinRequestErrorsArgs_TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,iVar5,0);
		  iVar5 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (piVar4[3],0,uVar2,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedPutJoinRequestErrors___
		                    );
		  if (iVar5 == 0) {
		    piVar4 = *(int **)(param2 + 0xc);
		    if (piVar4 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar4 + 0xb8) <
		           (uint)*(byte *)(
		                          Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                          + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar4 + 100) +
		                   (uint)*(byte *)(
		                                  Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                                  + 0xb8) * 4 + -4) !=
		          Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo))
		      {
		        System_Activator__CreateInstance
		                  (piVar4,
		                   Gameplay_Clans_Office_View_ClanInRatingListElement_ClanInRatingListElementArgs_TypeInfo
		                  );
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(int **)(iVar5 + 0x38) = piVar4;
		    if (piVar4 == (int *)0x0) {
		      uVar7 = 0;
		    }
		    else {
		      uVar7 = *(undefined8 *)(*(int *)(piVar4[9] + 0xc) + 0x10);
		    }
		    *(undefined8 *)(iVar5 + 0x48) = uVar7;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar5 = *param1_01;
		    if (*(ushort *)(iVar5 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x140);
		          goto code_r0x80e94fb0;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e94fb0:
		    iVar5 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    *(undefined8 *)(*(int *)(iVar5 + 0x14) + 0x10) =
		         *(undefined8 *)(*(int *)(piVar4[7] + 0x1c) + 0x10);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar5 = *(int *)(iVar5 + 0x20);
		    if (iVar5 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),*(undefined4 *)(iVar5 + 0x14));
		    }
		    iVar6 = piVar4[7];
		    uVar2 = *(undefined4 *)(piVar4[9] + 0x18);
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar2 = Gameplay_World_Model_ClanData__GetClanCultIconAssetId
		                      (iVar6,uVar2,*(undefined4 *)(iVar5 + 0xc),0);
		    iVar5 = System_Uri___ctor(0);
		    iVar5 = *(int *)(*(int *)(*(int *)(*(int *)(iVar5 + 0x38) + 0x10) + 0x84) + 0xc);
		    if (iVar5 != 0) {
		      param2_00 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      iVar6 = piVar4[7];
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      param1_00 = unnamed_function_1417(Core_Events_Scopes_ClansScope_ClansEventArgs_TypeInfo);
		      Core_Events_Scopes_UiScope_WindowClosedEventArgs__get_WindowCloseReason
		                (param1_00,param2_00,param3_00,iVar6,uVar2,0);
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0xc) * 4))
		                (*(undefined4 *)(iVar5 + 0x20),param1_00,*(undefined4 *)(iVar5 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F49")]
		[Address(RVA = "0x8E04", Offset = "0x8E04", VA = "0x8E04")]
		private void RequestJoinClanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestJoinClanResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__RequestJoinClanResultHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a5801c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_CancelJoinRequestResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DAT_ram_00a5801c = '\x01';
		  }
		  param1_00 = ServicesNamespace_ClansService__PutRequestForJoin(*(undefined4 *)(param1 + 0x18),0);
		  param1_01 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_01,param1,
		             Method_Gameplay_Clans_Office_Controller_ClanOfficeController_CancelJoinRequestResultHandler__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (param1_00,param1_01,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4A")]
		[Address(RVA = "0x8E05", Offset = "0x8E05", VA = "0x8E05")]
		public void CancelJoinRequest()
		{
		/* --- GHIDRA: CancelJoinRequest ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__CancelJoinRequest
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *piVar5;
		  int iVar6;
		  int local_4;
		  
		  if (DAT_ram_00a5801d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_ProtoDefaultAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28682);
		    DAT_ram_00a5801d = '\x01';
		  }
		  piVar5 = *(int **)(param2 + 0x20);
		  if ((piVar5 != (int *)0x0) && (Protocol_Common_ProtoDefaultAns_TypeInfo != *piVar5)) {
		    System_Activator__CreateInstance(piVar5,Protocol_Common_ProtoDefaultAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  if (piVar5[3] < 0) {
		    uVar2 = System_Uri___ctor(0);
		    uVar2 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar2,0);
		    local_4 = piVar5[3];
		    uVar3 = func_ii_1081(DAT_ram_00a66954,&local_4);
		    uVar3 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                      (StringLiteral_28682,uVar3,piVar5[4],0);
		    Core_Application_App__get_ToastController(uVar2,2,uVar3,0);
		  }
		  else {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar6 = *piVar5;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x140);
		          goto code_r0x80e9528c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80e9528c:
		    iVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar5,puVar4[1]);
		    *(undefined8 *)(*(int *)(iVar6 + 0x14) + 0x10) = 0;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    *(undefined8 *)(iVar6 + 0x48) = 0;
		    *(undefined4 *)(iVar6 + 0x38) = 0;
		    iVar6 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar6 = *(int *)(iVar6 + 0x1c);
		    if (iVar6 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                (*(undefined4 *)(iVar6 + 0x20),*(undefined4 *)(iVar6 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x8E06", Offset = "0x8E06", VA = "0x8E06")]
		private void CancelJoinRequestResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CancelJoinRequestResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__CancelJoinRequestResultHandler
		               (int *param1,undefined4 param2,undefined4 param3,int param4,undefined4 param5)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *param1_00;
		  undefined4 param3_00;
		  undefined4 param5_00;
		  int iVar6;
		  undefined4 uVar7;
		  
		  if (DAT_ram_00a5801e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_CreateClanResultHandler__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item(&UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		    DAT_ram_00a5801e = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar6 = 0x30;
		  if (param4 != 1) {
		    iVar6 = 0x2c;
		  }
		  uVar5 = *(undefined4 *)(iVar2 + iVar6);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar2 = Core_Errors_Expected_ExpectedBillingErrors__GetErrorCode
		                    (*(undefined4 *)(*(int *)(iVar2 + 8) + 0x78),uVar5,0);
		  if (iVar2 != 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_00;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x160);
		          goto code_r0x80e8dc7c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80e8dc7c:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    uVar7 = *(undefined4 *)(iVar2 + 0x20);
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar2 = Core_Gameplay_Managers_Requirements_RequirementsManager__CheckRestriction
		                      (uVar4,uVar7,*(undefined4 *)(iVar2 + 8),0);
		    if (iVar2 == 0) {
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      uVar7 = *(undefined4 *)(iVar2 + 8);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param3_00 = *(undefined4 *)(iVar2 + 8);
		      iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		      param5_00 = *(undefined4 *)(iVar2 + 0x20);
		      uVar4 = unnamed_function_1417(UI_Windows_RequirementsWindow_RequirementsWindowArgs_TypeInfo);
		      UI_Windows_RequirementsWindow_RequirementsWindowArgs___ctor
		                (uVar4,uVar7,param3_00,uVar5,param5_00,0,0);
		      UI_Windows_RequirementsWindow__HandleContent(uVar4,0);
		      return;
		    }
		    uVar4 = System_Uri___ctor(0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar7 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = unnamed_function_1417(Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo);
		    Core_Application_Managers_Connection_ServerConnectionDelay__ResetAll(iVar2,uVar4,uVar7,0);
		    *(undefined4 *)(iVar2 + 0x1c) = uVar5;
		    *(undefined4 *)(iVar2 + 0x18) = param2;
		    uVar5 = ServicesNamespace_ClansService__RefuseJoinRequests(param1[6],param2,param3,param4,0);
		    uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		    UnityEngine_UIElements_VisualElement__get_layout
		              (uVar4,param1,
		               Method_Gameplay_Clans_Office_Controller_ClanOfficeController_CreateClanResultHandler__
		               ,0);
		    uVar5 = ServicesNamespace_MainService__GetUserStats
		                      (uVar5,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    DG_Tweening_TweenParams__SetId
		              (uVar5,iVar2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x8E07", Offset = "0x8E07", VA = "0x8E07")]
		public void CreateClan(string name, string description, ClanFlags flags)
		{
		/* --- GHIDRA: CreateClan ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__CreateClan
		               (int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  int iVar4;
		  int *piVar5;
		  
		  if (DAT_ram_00a5801f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_Clans_ExpectedCreateClanErrors_ExpectedCreateClanErrorsArgs_TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCreateClanErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_World_Controller_IUserIslesWorldMovement_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Clans_ProtoCreateClanAns_TypeInfo);
		    DAT_ram_00a5801f = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Clans_ProtoCreateClanAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Clans_ProtoCreateClanAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar4 = param1_00[4];
		  uVar2 = unnamed_function_1417
		                    (
		                    Core_Errors_Expected_Clans_ExpectedCreateClanErrors_ExpectedCreateClanErrorsArgs_TypeInfo
		                    );
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(uVar2,iVar4,0);
		  iVar4 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,uVar2,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedCreateClanErrors___
		                    );
		  if (iVar4 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x230);
		          goto code_r0x80e9544c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x2e);
		code_r0x80e9544c:
		    uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    Core_Gameplay_Managers_ClansManager__ShowClanOfficeWindow(uVar2,0);
		    iVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar4 = *(int *)(iVar4 + 0x24);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),*(undefined4 *)(iVar4 + 0x14));
		    }
		    piVar5 = (int *)param1[7];
		    iVar4 = *piVar5;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Gameplay_World_Controller_IUserIslesWorldMovement_TypeInfo ==
		            *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80e95505;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar5,Gameplay_World_Controller_IUserIslesWorldMovement_TypeInfo,
		                                  0);
		code_r0x80e95505:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar5,puVar3[1]);
		    piVar5 = *(int **)(param2 + 0xc);
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) <
		           (uint)*(byte *)(Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo + 0xb8)) ||
		         (*(int *)(*(int *)(*piVar5 + 100) +
		                   (uint)*(byte *)(Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo + 0xb8
		                                  ) * 4 + -4) !=
		          Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo)) {
		        System_Activator__CreateInstance
		                  (piVar5,Core_Events_Scopes_ClansScope_CreateClanEventArgs_TypeInfo);
		        do {
		          halt_trap();
		        } while( true );
		      }
		    }
		    *(undefined8 *)(piVar5 + 4) = *(undefined8 *)(param1_00 + 6);
		    iVar4 = System_Uri___ctor(0);
		    iVar4 = *(int *)(*(int *)(*(int *)(*(int *)(iVar4 + 0x38) + 0x10) + 0x84) + 8);
		    if (iVar4 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar4 + 0xc) * 4))
		                (*(undefined4 *)(iVar4 + 0x20),piVar5,*(undefined4 *)(iVar4 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x8E08", Offset = "0x8E08", VA = "0x8E08")]
		private void CreateClanResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: CreateClanResultHandler ---
		void Gameplay_Clans_Office_Controller_ClanOfficeController__CreateClanResultHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  undefined4 param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5765b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowAboutClansTab__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowClanCreationTab__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowVacanciesTab__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Func_IHideableMediator__TypeInfo);
		    DAT_ram_00a5765b = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_ClanOfficeModel__ClanOfficeEvents__ClanOfficeController__ClanOfficeWindow___ctor__
		            );
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___TypeInfo
		                        );
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator____ctor__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowAboutClansTab__,0
		               );
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,0,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowClanCreationTab__
		                ,0);
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,1,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  uVar1 = unnamed_function_1417(System_Func_IHideableMediator__TypeInfo);
		  func_ii_19797(uVar1,param1,
		                Method_Gameplay_Clans_Office_Controller_ClanOfficeViewMediator_ShowVacanciesTab__,0)
		  ;
		  System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		            (param1_00,2,uVar1,
		             Method_System_Collections_Generic_Dictionary_uint__Func_IHideableMediator___Add__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  return;
		}
		*/

		}

		// Token: 0x04002393 RID: 9107
		[Token(Token = "0x4002393")]
		[FieldOffset(Offset = "0x18")]
		private ClansService _clansService;

		// Token: 0x04002394 RID: 9108
		[Token(Token = "0x4002394")]
		[FieldOffset(Offset = "0x1C")]
		private IUserIslesWorldMovement _userWorldMovement;
	}
}

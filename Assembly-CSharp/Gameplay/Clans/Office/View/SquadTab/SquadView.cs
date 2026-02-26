using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A12 RID: 2578
	[Token(Token = "0x2000A12")]
	public class SquadView : MonoBehaviourWithStates<SquadView.State>
	{
		// Token: 0x14000195 RID: 405
		// (add) Token: 0x06003D43 RID: 15683 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D44 RID: 15684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000195")]
		public event Action<MemberSlotView, SquadListElement> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D43")]
			[Address(RVA = "0x8C03", Offset = "0x8C03", VA = "0x8C03")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D44")]
			[Address(RVA = "0x8C04", Offset = "0x8C04", VA = "0x8C04")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x06003D45 RID: 15685 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D46 RID: 15686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000196")]
		public event Action<MemberSlotView, SquadListElement> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D45")]
			[Address(RVA = "0x8C05", Offset = "0x8C05", VA = "0x8C05")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D46")]
			[Address(RVA = "0x8C06", Offset = "0x8C06", VA = "0x8C06")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x06003D47 RID: 15687 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D48 RID: 15688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000197")]
		public event Action RentButtonClickedEvent
		{
			[Token(Token = "0x6003D47")]
			[Address(RVA = "0x8C07", Offset = "0x8C07", VA = "0x8C07")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D48")]
			[Address(RVA = "0x8C08", Offset = "0x8C08", VA = "0x8C08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1E")]
		public TextMeshProUGUI Class
		{
			[Token(Token = "0x6003D49")]
			[Address(RVA = "0x8C09", Offset = "0x8C09", VA = "0x8C09")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1F")]
		public TextMeshProUGUI Squad
		{
			[Token(Token = "0x6003D4A")]
			[Address(RVA = "0x8C0A", Offset = "0x8C0A", VA = "0x8C0A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C20")]
		public TextMeshProUGUI MembersInClan
		{
			[Token(Token = "0x6003D4B")]
			[Address(RVA = "0x8C0B", Offset = "0x8C0B", VA = "0x8C0B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C21")]
		public TextMeshProUGUI MembersInSquads
		{
			[Token(Token = "0x6003D4C")]
			[Address(RVA = "0x8C0C", Offset = "0x8C0C", VA = "0x8C0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C22")]
		public TextMeshProUGUI PlacesAvailable
		{
			[Token(Token = "0x6003D4D")]
			[Address(RVA = "0x8C0D", Offset = "0x8C0D", VA = "0x8C0D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C23")]
		public TextMeshProUGUI SeasonStatus
		{
			[Token(Token = "0x6003D4E")]
			[Address(RVA = "0x8C0E", Offset = "0x8C0E", VA = "0x8C0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C24")]
		public BacktimeViewUGUI SeasonBacktime
		{
			[Token(Token = "0x6003D4F")]
			[Address(RVA = "0x8C0F", Offset = "0x8C0F", VA = "0x8C0F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C25")]
		public Toggle RulesToggle
		{
			[Token(Token = "0x6003D50")]
			[Address(RVA = "0x8C10", Offset = "0x8C10", VA = "0x8C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x8C11", Offset = "0x8C11", VA = "0x8C11")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__Awake(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f3c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_SquadTab_SquadView_ToggleObjects__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		    DAT_ram_00a57f3c = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_Gameplay_Clans_Office_View_SquadTab_SquadView_ToggleObjects__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext___Invoke
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__RemoveListener__);
		  return;
		}
		*/

		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x8C12", Offset = "0x8C12", VA = "0x8C12")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__OnDestroy
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  
		  if (DAT_ram_00a57f3d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadView_State__get_CurrentState__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__);
		    DAT_ram_00a57f3d = '\x01';
		  }
		  if (param2 == 0) {
		    param2_00 = *(undefined4 *)(param1 + 0x48);
		  }
		  else {
		    *(undefined4 *)(param1 + 0x48) = *(undefined4 *)(param1 + 0x18);
		    param2_00 = 0;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1,param2_00,Method_UI_MonoBehaviourWithStates_SquadView_State__set_CurrentState__)
		  ;
		  return;
		}
		*/

		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x8C13", Offset = "0x8C13", VA = "0x8C13")]
		private void ToggleObjects(bool enable)
		{
		/* --- GHIDRA: ToggleObjects ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__ToggleObjects
		               (int param1,int *param2,int *param3,undefined4 param4,undefined4 param5,
		               undefined4 param6)
		
		{
		  bool bVar1;
		  uint uVar2;
		  int iVar3;
		  int iVar4;
		  uint *puVar5;
		  undefined4 uVar6;
		  int iVar7;
		  undefined4 uVar8;
		  int iVar9;
		  int iVar10;
		  int iVar11;
		  int *piVar12;
		  
		  iVar10 = 0;
		  if (DAT_ram_00a57f3e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_ColossusPartiesInfoDic__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_ICollection_SquadModel_PartyData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ColossusPartiesInfoDic__TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_SquadModel_PartyData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_SquadListElement___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_SquadTab_SquadListElement___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadView_CrossButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_SquadTab_SquadView_JoinButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_SquadTab_SquadView_RentButtonClickedEventHandler__
		              );
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a57f3e = '\x01';
		  }
		  iVar9 = *(int *)(param1 + 0x44);
		  if (0 < *(int *)(iVar9 + 0xc)) {
		    do {
		      iVar11 = *(int *)(iVar9 + iVar10 * 4 + 0x10);
		      uVar6 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                (uVar6,param1,
		                 Method_Gameplay_Clans_Office_View_SquadTab_SquadView_JoinButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a57f2f == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		        DAT_ram_00a57f2f = '\x01';
		      }
		      iVar3 = *(int *)(iVar11 + 0x34);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar6,0);
		        uVar8 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		           iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar11 + 0x34,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar6 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		      System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                (uVar6,param1,
		                 Method_Gameplay_Clans_Office_View_SquadTab_SquadView_CrossButtonClickedEventHandler__
		                 ,0);
		      if (DAT_ram_00a57f31 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		        DAT_ram_00a57f31 = '\x01';
		      }
		      iVar3 = *(int *)(iVar11 + 0x38);
		      do {
		        iVar7 = 0;
		        iVar4 = func_ii_7048(iVar3,uVar6,0);
		        uVar8 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		        if ((iVar4 != 0) &&
		           (iVar7 = func_ii_1082(iVar4,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		           iVar7 == 0)) {
		          System_Activator__CreateInstance(iVar4,uVar8);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar7 = func_ii_4329(iVar11 + 0x38,iVar7,iVar3);
		        bVar1 = iVar7 != iVar3;
		        iVar3 = iVar7;
		      } while (bVar1);
		      uVar8 = *(undefined4 *)(*(int *)(iVar11 + 0x2c) + 0xb4);
		      uVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		      Utils_ObjectUtils__IsNotNull
		                (uVar6,param1,
		                 Method_Gameplay_Clans_Office_View_SquadTab_SquadView_RentButtonClickedEventHandler__
		                 ,0);
		      UnityEngine_Events_UnityAction___ctor(uVar8,uVar6,0);
		      uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (iVar11,0);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      UnityEngine_Application__get_isPlaying(uVar6,0);
		      iVar10 = iVar10 + 1;
		    } while (iVar10 < *(int *)(iVar9 + 0xc));
		  }
		  uVar2 = 0;
		  iVar10 = *param2;
		  if (*(ushort *)(iVar10 + 0xb6) != 0) {
		    do {
		      if (System_Collections_Generic_ICollection_ColossusPartiesInfoDic__TypeInfo ==
		          *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8)) {
		        puVar5 = (uint *)(iVar10 + *(int *)(*(int *)(iVar10 + 0x58) + uVar2 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e82524;
		      }
		      uVar2 = uVar2 + 1;
		    } while (*(ushort *)(iVar10 + 0xb6) != uVar2);
		  }
		  puVar5 = (uint *)func_ii_1080(param2,
		                                System_Collections_Generic_ICollection_ColossusPartiesInfoDic__TypeInfo
		                                ,0);
		code_r0x80e82524:
		  uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		  uVar6 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Office_View_SquadTab_SquadListElement___TypeInfo,uVar6);
		  *(undefined4 *)(param1 + 0x44) = uVar6;
		  iVar10 = 0;
		  do {
		    iVar9 = *param2;
		    if (*(ushort *)(iVar9 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_ICollection_ColossusPartiesInfoDic__TypeInfo == *piVar12) {
		          puVar5 = (uint *)(iVar9 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80e825b6;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ColossusPartiesInfoDic__TypeInfo
		                                  ,0);
		code_r0x80e825b6:
		    iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(param2,puVar5[1]);
		    if (iVar9 <= iVar10) {
		      iVar10 = 0;
		      do {
		        iVar9 = *param3;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_ICollection_SquadModel_PartyData__TypeInfo == *piVar12) {
		              puVar5 = (uint *)(iVar9 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e8286b;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(param3,
		                                      System_Collections_Generic_ICollection_SquadModel_PartyData__TypeInfo
		                                      ,0);
		code_r0x80e8286b:
		        iVar9 = (**(code **)((ulonglong)*puVar5 * 4))(param3,puVar5[1]);
		        if (iVar9 <= iVar10) {
		          return;
		        }
		        uVar6 = *(undefined4 *)(*(int *)(param1 + 0x44) + iVar10 * 4 + 0x10);
		        iVar9 = *param3;
		        if (*(ushort *)(iVar9 + 0xb6) != 0) {
		          uVar2 = 0;
		          do {
		            piVar12 = (int *)(*(int *)(iVar9 + 0x58) + uVar2 * 8);
		            if (System_Collections_Generic_IList_SquadModel_PartyData__TypeInfo == *piVar12) {
		              puVar5 = (uint *)(iVar9 + piVar12[1] * 8 + 0xc0);
		              goto code_r0x80e828f8;
		            }
		            uVar2 = uVar2 + 1;
		          } while (*(ushort *)(iVar9 + 0xb6) != uVar2);
		        }
		        puVar5 = (uint *)func_ii_1080(param3,
		                                      System_Collections_Generic_IList_SquadModel_PartyData__TypeInfo
		                                      ,0);
		code_r0x80e828f8:
		        uVar8 = (**(code **)((ulonglong)*puVar5 * 4))(param3,iVar10,puVar5[1]);
		        Gameplay_Clans_Office_View_SquadTab_SquadListElement__Init(uVar6,uVar8,puVar5);
		        iVar10 = iVar10 + 1;
		      } while( true );
		    }
		    uVar6 = *(undefined4 *)(param1 + 0x1c);
		    uVar8 = *(undefined4 *)(param1 + 0x20);
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      func_ii_306000(UnityEngine_Object_TypeInfo);
		    }
		    iVar9 = func_ii_6805(uVar8,uVar6,Method_UnityEngine_Object_Instantiate_SquadListElement___);
		    iVar11 = *param2;
		    if (*(ushort *)(iVar11 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        piVar12 = (int *)(*(int *)(iVar11 + 0x58) + uVar2 * 8);
		        if (System_Collections_Generic_IList_ColossusPartiesInfoDic__TypeInfo == *piVar12) {
		          puVar5 = (uint *)(iVar11 + piVar12[1] * 8 + 0xc0);
		          goto code_r0x80e8266e;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar11 + 0xb6) != uVar2);
		    }
		    puVar5 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_IList_ColossusPartiesInfoDic__TypeInfo,
		                                  0);
		code_r0x80e8266e:
		    uVar6 = (**(code **)((ulonglong)*puVar5 * 4))(param2,iVar10,puVar5[1]);
		    Gameplay_Clans_Office_View_SquadTab_SquadListElement__set_Dic(iVar9,uVar6,param4,param5,puVar5);
		    uVar6 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar6,param1,
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadView_JoinButtonClickedEventHandler__,
		               0);
		    if (DAT_ram_00a57f2e == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		      DAT_ram_00a57f2e = '\x01';
		    }
		    iVar11 = *(int *)(iVar9 + 0x34);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar11,uVar6,0);
		      uVar8 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		         iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar9 + 0x34,iVar3,iVar11);
		      bVar1 = iVar3 != iVar11;
		      iVar11 = iVar3;
		    } while (bVar1);
		    uVar6 = unnamed_function_1417(System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		              (uVar6,param1,
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadView_CrossButtonClickedEventHandler__
		               ,0);
		    if (DAT_ram_00a57f30 == '\0') {
		      Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		      DAT_ram_00a57f30 = '\x01';
		    }
		    iVar11 = *(int *)(iVar9 + 0x38);
		    do {
		      iVar3 = 0;
		      iVar7 = UnityEngine_UI_Image__set_sprite(iVar11,uVar6,0);
		      uVar8 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		      if ((iVar7 != 0) &&
		         (iVar3 = func_ii_1082(iVar7,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		         iVar3 == 0)) {
		        System_Activator__CreateInstance(iVar7,uVar8);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar3 = func_ii_4329(iVar9 + 0x38,iVar3,iVar11);
		      bVar1 = iVar3 != iVar11;
		      iVar11 = iVar3;
		    } while (bVar1);
		    uVar8 = *(undefined4 *)(*(int *)(iVar9 + 0x2c) + 0xb4);
		    uVar6 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		    Utils_ObjectUtils__IsNotNull
		              (uVar6,param1,
		               Method_Gameplay_Clans_Office_View_SquadTab_SquadView_RentButtonClickedEventHandler__,
		               0);
		    Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar8,uVar6,0);
		    piVar12 = *(int **)(param1 + 0x44);
		    iVar11 = func_ii_1082(iVar9,*(undefined4 *)(*piVar12 + 0x20));
		    if (iVar11 == 0) {
		      uVar6 = func_ii_1083();
		      func_ii_1050(uVar6,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    piVar12[iVar10 + 4] = iVar9;
		    iVar10 = iVar10 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x8C14", Offset = "0x8C14", VA = "0x8C14")]
		public void Init(IList<ColossusPartiesInfoDic> partyDics, IList<SquadModel.PartyData> parties, IList<ColossusSlotsInfoDic> slotDics, IBalanceSource treasury)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__Init(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x54);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x8C15", Offset = "0x8C15", VA = "0x8C15")]
		private void RentButtonClickedEventHandler()
		{
		/* --- GHIDRA: RentButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__RentButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x4c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x8C16", Offset = "0x8C16", VA = "0x8C16")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		/* --- GHIDRA: JoinButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__JoinButtonClickedEventHandler
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x50);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x8C17", Offset = "0x8C17", VA = "0x8C17")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		/* --- GHIDRA: CrossButtonClickedEventHandler ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__CrossButtonClickedEventHandler
		               (int param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a57f3f == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_MonoBehaviourWithStates_SquadView_State___ctor__);
		    Mono_Security_ASN1__get_Item(&Gameplay_Clans_Office_View_SquadTab_SquadListElement___TypeInfo);
		    DAT_ram_00a57f3f = '\x01';
		  }
		  uVar1 = Mono_Security_ASN1Convert__ToOid
		                    (Gameplay_Clans_Office_View_SquadTab_SquadListElement___TypeInfo,0);
		  *(undefined4 *)(param1 + 0x44) = uVar1;
		  ScreenAdaptation_Common_AppSize__Update
		            (param1,Method_UI_MonoBehaviourWithStates_SquadView_State___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x8C18", Offset = "0x8C18", VA = "0x8C18")]
		public SquadView()
		{
		}

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SquadListElement _partyPrefab;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _class;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _squad;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _membersInClan;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _membersInSquads;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _placesAvailable;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _rulesToggle;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatus;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _seasonBacktime;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x44")]
		private SquadListElement[] _parties;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x48")]
		private SquadView.State _savedState;

		// Token: 0x02000A13 RID: 2579
		[Token(Token = "0x2000A13")]
		public enum State
		{
			// Token: 0x04002227 RID: 8743
			[Token(Token = "0x4002227")]
			UNKNOWN_STATE,
			// Token: 0x04002228 RID: 8744
			[Token(Token = "0x4002228")]
			DEFAULT,
			// Token: 0x04002229 RID: 8745
			[Token(Token = "0x4002229")]
			EMPTY
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_JoinButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__add_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f36 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f36 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x4c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x4c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_JoinButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__remove_JoinButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f37 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f37 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_CrossButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__add_CrossButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57f38 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_MemberSlotView__SquadListElement__TypeInfo);
		    DAT_ram_00a57f38 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x50);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_MemberSlotView__SquadListElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_MemberSlotView__SquadListElement__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x50,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_CrossButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__remove_CrossButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57f39 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57f39 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)UnityEngine_UI_Image__set_sprite(param1_00,param2,0),
		         param1_01 == (int *)0x0 || (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_RentButtonClickedEvent ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__add_RentButtonClickedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a57f3a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a57f3a = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x54);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x54,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_RulesToggle ---
		void Gameplay_Clans_Office_View_SquadTab_SquadView__get_RulesToggle(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined4 param1_01;
		  
		  if (DAT_ram_00a57f3b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Clans_Office_View_SquadTab_SquadView_ToggleObjects__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_bool__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		    DAT_ram_00a57f3b = '\x01';
		  }
		  param1_01 = *(undefined4 *)(*(int *)(param1 + 0x38) + 0xc0);
		  param1_00 = unnamed_function_1417(UnityEngine_Events_UnityAction_bool__TypeInfo);
		  UnityEngine_UI_Toggle__set_group
		            (param1_00,param1,Method_Gameplay_Clans_Office_View_SquadTab_SquadView_ToggleObjects__,0
		            );
		  UnityEngine_Events_UnityEvent_InputAction_CallbackContext____ctor
		            (param1_01,param1_00,Method_UnityEngine_Events_UnityEvent_bool__AddListener__);
		  return;
		}
		*/

}

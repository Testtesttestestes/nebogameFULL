using System;
using System.Threading;
using Gameplay.Portals.Events;
using Gameplay.Portals.Model;
using Gameplay.Portals.View.RatingTab;
using Il2CppDummyDll;
using MVC;
using MVC.Interfaces;

namespace Gameplay.Portals.Controller
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	public class PortalsRatingViewMediator : AbstractViewMediator<PortalsRatingModel, PortalsEvents, PortalsRatingController, PortalsRatingView>, IHideableMediator
	{
		// Token: 0x06002443 RID: 9283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002443")]
		[Address(RVA = "0x7592", Offset = "0x7592", VA = "0x7592", Slot = "14")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__Dispose(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (param1[6] != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (param1[6],0);
		    if (param1[6] != 0) {
		      System_Threading_CancellationTokenSource__Cancel(param1[6],0);
		    }
		  }
		  param1[6] = 0;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		            (param1,0,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar1 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar1,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar1,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002444")]
		[Address(RVA = "0x7593", Offset = "0x7593", VA = "0x7593", Slot = "21")]
		public void Hide()
		{
		/* --- GHIDRA: Hide ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__Hide
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  if (DAT_ram_00a5816c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView___ctor__
		              );
		    DAT_ram_00a5816c = '\x01';
		  }
		  Gameplay_Combat_TeamCombat_View_AbstractTeamCombatView_object___get_HideInstantElements
		            (param1,param2,param3,param4,
		             Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002445")]
		[Address(RVA = "0x7594", Offset = "0x7594", VA = "0x7594")]
		public PortalsRatingViewMediator(PortalsRatingModel model, PortalsEvents events, PortalsRatingController controller)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator___ctor
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  undefined4 uVar5;
		  
		  if (DAT_ram_00a5816d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__set_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandlePortalRatingReceivedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStartRequestEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStopRequestEvent__
		              );
		    DAT_ram_00a5816d = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandlePortalRatingReceivedEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0xc);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStartRequestEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0xc) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStopRequestEvent__
		               ,0);
		    piVar4 = (int *)func_ii_7048(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x10) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x10) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param1[3] = param2;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x13c));
		  if (iVar1 != 0) {
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x34);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandlePortalRatingReceivedEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x34) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0x34) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0xc);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStartRequestEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0xc) = 0;
		    }
		    else if ((System_Action_TypeInfo != *piVar4) ||
		            (*(int **)(iVar2 + 0xc) = piVar4, *piVar4 != iVar1)) {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x13c));
		    uVar5 = *(undefined4 *)(iVar2 + 0x10);
		    uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		    UnityEngine_Events_UnityEvent__AddListener
		              (uVar3,param1,
		               Method_Gameplay_Portals_Controller_PortalsRatingViewMediator_HandleStopRequestEvent__
		               ,0);
		    piVar4 = (int *)UnityEngine_UI_Image__set_sprite(uVar5,uVar3,0);
		    iVar1 = System_Action_TypeInfo;
		    if (piVar4 == (int *)0x0) {
		      *(undefined4 *)(iVar2 + 0x10) = 0;
		      return;
		    }
		    if ((System_Action_TypeInfo != *piVar4) || (*(int **)(iVar2 + 0x10) = piVar4, *piVar4 != iVar1))
		    {
		      System_Activator__CreateInstance(piVar4,iVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x170006D3 RID: 1747
		// (set) Token: 0x06002446 RID: 9286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D3")]
		public override PortalsEvents Events
		{
			[Token(Token = "0x6002446")]
			[Address(RVA = "0x7595", Offset = "0x7595", VA = "0x7595", Slot = "16")]
			set
			{
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (set) Token: 0x06002447 RID: 9287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006D4")]
		public override PortalsRatingView View
		{
			[Token(Token = "0x6002447")]
			[Address(RVA = "0x7596", Offset = "0x7596", VA = "0x7596", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x7597", Offset = "0x7597", VA = "0x7597")]
		private void HandleStopRequestEvent()
		{
		/* --- GHIDRA: HandleStopRequestEvent ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__HandleStopRequestEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  int local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58170 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Threading_CancellationTokenSource_TypeInfo);
		    DAT_ram_00a58170 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Threading_CancellationTokenSource_TypeInfo);
		  Gameplay_Combat_Control_Conveyor__Next(param1_00,0);
		  *(undefined4 *)(param1 + 0x18) = param1_00;
		  if (DAT_ram_00a58174 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalsRatingViewMediator__ShowAwaitReceivingData_d__16___
		              );
		    DAT_ram_00a58174 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_14 = 0x15e;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_10 = param1_00;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PortalCombatViewMediator__HandleSetupView_d__2_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalsRatingViewMediator__ShowAwaitReceivingData_d__16___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x7598", Offset = "0x7598", VA = "0x7598")]
		private void HandleStartRequestEvent()
		{
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x7599", Offset = "0x7599", VA = "0x7599")]
		private void HandlePortalRatingReceivedEvent()
		{
		/* --- GHIDRA: HandlePortalRatingReceivedEvent ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__HandlePortalRatingReceivedEvent
		               (int *param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a58171 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Array_Empty_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyPortalRatingView_State__set_CurrentState__);
		    DAT_ram_00a58171 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar5 = 
		  Method_System_Array_Empty_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___;
		  piVar4 = *(int **)(iVar2 + 0x10);
		  iVar2 = *(int *)(
		                  Method_System_Array_Empty_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		                  + 0x1c);
		  if (iVar2 == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_System_Array_Empty_UserInPortalRatingListElement_UserInPortalRatingListElementArgs___
		              );
		    iVar2 = *(int *)(iVar5 + 0x1c);
		  }
		  iVar2 = *(int *)(iVar2 + 8);
		  if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		    iVar2 = func_ii_1079(iVar2);
		  }
		  if (*(int *)(iVar2 + 0x74) == 0) {
		    func_ii_306000(iVar2);
		  }
		  iVar5 = *(int *)(*(int *)(iVar5 + 0x1c) + 8);
		  if ((*(byte *)(iVar5 + 0xbd) & 1) == 0) {
		    iVar5 = func_ii_1079(iVar5);
		  }
		  iVar2 = *piVar4;
		  (**(code **)((ulonglong)*(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar2 + 0x10)
		              * 4))(piVar4,**(undefined4 **)(iVar5 + 0x5c),
		                    *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar2 + 0x14))
		  ;
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(undefined4 *)(iVar5 + 0x14),2,
		             Method_UI_MonoBehaviourWithStates_MyPortalRatingView_State__set_CurrentState__);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (uVar3,0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  uVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x148) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x14c));
		  iVar5 = Gameplay_Portals_Controller_PortalsRatingController___ctor(uVar3,param1);
		  if (iVar5 == 0) {
		    iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    bVar1 = *(byte *)(param1[2] + 0x1c);
		    uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (*(undefined4 *)(iVar5 + 0x18),0);
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,(uint)bVar1,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600244B RID: 9291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244B")]
		[Address(RVA = "0x759A", Offset = "0x759A", VA = "0x759A")]
		private void SetupView()
		{
		/* --- GHIDRA: SetupView ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__SetupView
		               (undefined4 param1,undefined4 param2)
		
		{
		  Gameplay_Portals_Controller_PortalsRatingViewMediator__ShowRating(param1,param1);
		  Gameplay_Portals_Controller_PortalsRatingViewMediator__UpdateOSAView(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244C")]
		[Address(RVA = "0x759B", Offset = "0x759B", VA = "0x759B")]
		private void ShowRating()
		{
		/* --- GHIDRA: ShowRating ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__ShowRating
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a58172 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__UserInPortalRatingsViewsHolder__get_IsInitialized__
		              );
		    DAT_ram_00a58172 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (*(char *)(*(int *)(iVar1 + 0x10) + 0x50) != '\0') {
		    iVar1 = param1[2];
		    if (DAT_ram_00a5812e == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____get_Item__
		                );
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		                );
		      DAT_ram_00a5812e = '\x01';
		    }
		    uVar2 = GAFInternal_Reader_GAFReader__OpenTag
		                      (*(undefined4 *)(iVar1 + 0x10),0,
		                       Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs_____get_Item__
		                      );
		    uVar2 = System_Collections_Generic_List_object___get_Item
		                      (uVar2,0,
		                       Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs____get_Item__
		                      );
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    iVar3 = **(int **)(iVar1 + 0x10);
		    (**(code **)((ulonglong)
		                 *(uint *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x10) * 4))
		              (*(int **)(iVar1 + 0x10),uVar2,
		               *(undefined4 *)(s_Allocator__0___MaxBlockCount__1__ram_00000478 + iVar3 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244D")]
		[Address(RVA = "0x759C", Offset = "0x759C", VA = "0x759C")]
		private void UpdateOSAView()
		{
		/* --- GHIDRA: UpdateOSAView ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__UpdateOSAView
		               (int *param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a58173 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__get_Model__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_MonoBehaviourWithStates_MyPortalRatingView_State__set_CurrentState__);
		    DAT_ram_00a58173 = '\x01';
		  }
		  iVar2 = param1[2];
		  if (DAT_ram_00a5812f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__get_Item__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		              );
		    DAT_ram_00a5812f = '\x01';
		  }
		  param1_00 = GAFInternal_Reader_GAFReader__OpenTag
		                        (*(undefined4 *)(iVar2 + 0x14),0,
		                         Method_System_Collections_Generic_Dictionary_RatingPeriods__Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs___get_Item__
		                        );
		  iVar2 = System_Collections_Generic_List_object___get_Item
		                    (param1_00,0,
		                     Method_System_Collections_Generic_Dictionary_uint__UserInPortalRatingListElement_UserInPortalRatingListElementArgs__get_Item__
		                    );
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  if (iVar2 != 0) {
		    UI_Elements_Buildings_SpellItemArgs___ctor
		              (*(undefined4 *)(*(int *)(iVar1 + 0x14) + 0x1c),iVar2,
		               Method_UI_Elements_GenericList_GenericListElement_UserInRatingListElement_UserInRatingListElementArgs__Init__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x15c));
		    Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		              (*(undefined4 *)(iVar2 + 0x14),1,
		               Method_UI_MonoBehaviourWithStates_MyPortalRatingView_State__set_CurrentState__);
		    return;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (*(int *)(iVar1 + 0x14),2,
		             Method_UI_MonoBehaviourWithStates_MyPortalRatingView_State__set_CurrentState__);
		  return;
		}
		*/

		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244E")]
		[Address(RVA = "0x759D", Offset = "0x759D", VA = "0x759D")]
		private void UpdateMyRatingView()
		{
		/* --- GHIDRA: UpdateMyRatingView ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__UpdateMyRatingView
		               (int *param1,undefined4 param2)
		
		{
		  if (*param1 != 0) {
		    System_Runtime_CompilerServices_AsyncTaskMethodBuilder__AwaitUnsafeOnCompleted_ConfiguredTaskAwaitable_ConfiguredTaskAwaiter__WebRequestStream__WriteChunkTrailer_d__40_
		              (*param1,0);
		    if (*param1 != 0) {
		      System_Threading_CancellationTokenSource__Cancel(*param1,0);
		    }
		  }
		  *param1 = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600244F")]
		[Address(RVA = "0x759E", Offset = "0x759E", VA = "0x759E")]
		private static void CancelAwaitReceivingData(ref CancellationTokenSource cts)
		{
		/* --- GHIDRA: CancelAwaitReceivingData ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__CancelAwaitReceivingData
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined4 local_28;
		  undefined8 local_24;
		  undefined8 local_1c;
		  undefined4 local_14;
		  undefined4 local_10;
		  undefined4 local_c;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a58174 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalsRatingViewMediator__ShowAwaitReceivingData_d__16___
		              );
		    DAT_ram_00a58174 = '\x01';
		  }
		  local_8 = 0;
		  System_Linq_Enumerable__ToDictionary_KeyValuePair_object__object___object__object_(&local_38,0);
		  local_1c = local_30;
		  local_28 = 0xffffffff;
		  local_24 = local_38;
		  local_14 = param2;
		  local_10 = param3;
		  local_c = param1;
		  System_Runtime_CompilerServices_AsyncVoidMethodBuilder__Start_PortalCombatViewMediator__HandleSetupView_d__2_
		            (&local_24,&local_28,
		             Method_System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Start_PortalsRatingViewMediator__ShowAwaitReceivingData_d__16___
		            );
		  return;
		}
		*/

		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002450")]
		[Address(RVA = "0x759F", Offset = "0x759F", VA = "0x759F")]
		private void ShowAwaitReceivingData(int delay, CancellationTokenSource cts)
		{
		}

		// Token: 0x040013F5 RID: 5109
		[Token(Token = "0x40013F5")]
		[FieldOffset(Offset = "0x18")]
		private CancellationTokenSource _cancelReceivingDataTs;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Events ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__set_Events
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a5816e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__set_View__
		              );
		    DAT_ram_00a5816e = '\x01';
		  }
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  param1[5] = param2;
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  iVar2 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(uVar1,0);
		  if (iVar2 != 0) {
		    Gameplay_Portals_Controller_PortalsRatingViewMediator__HandlePortalRatingReceivedEvent
		              (param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_View ---
		void Gameplay_Portals_Controller_PortalsRatingViewMediator__set_View(int *param1,undefined4 param2)
		
		{
		  byte bVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5816f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractViewMediator_PortalsRatingModel__PortalsEvents__PortalsRatingController__PortalsRatingView__get_Model__
		              );
		    DAT_ram_00a5816f = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x158) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x15c));
		  bVar1 = *(byte *)(param1[2] + 0x1c);
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(iVar2 + 0x18),0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,(uint)bVar1,0);
		  return;
		}
		*/

}

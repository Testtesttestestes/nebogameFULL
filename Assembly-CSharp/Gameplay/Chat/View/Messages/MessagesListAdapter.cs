using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Gameplay.Chat.Model.Data.Message;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Messages
{
	// Token: 0x02000AFD RID: 2813
	[Token(Token = "0x2000AFD")]
	public class MessagesListAdapter : OSA<BaseParamsWithPrefab, MessageViewHolder>
	{
		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x060043E0 RID: 17376 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060043E1 RID: 17377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D60")]
		public SimpleDataHelper<ChatMessageItem> Data
		{
			[Token(Token = "0x60043E0")]
			[Address(RVA = "0x9293", Offset = "0x9293", VA = "0x9293")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60043E1")]
			[Address(RVA = "0x9294", Offset = "0x9294", VA = "0x9294")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x140001AA RID: 426
		// (add) Token: 0x060043E2 RID: 17378 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E3 RID: 17379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AA")]
		public event Action<ChatMessageItem> MessageHasBeenViewedEvent
		{
			[Token(Token = "0x60043E2")]
			[Address(RVA = "0x9295", Offset = "0x9295", VA = "0x9295")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E3")]
			[Address(RVA = "0x9296", Offset = "0x9296", VA = "0x9296")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001AB RID: 427
		// (add) Token: 0x060043E4 RID: 17380 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E5 RID: 17381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AB")]
		public event Action<ChatMessageItem> MessageDeleteRequestEvent
		{
			[Token(Token = "0x60043E4")]
			[Address(RVA = "0x9297", Offset = "0x9297", VA = "0x9297")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E5")]
			[Address(RVA = "0x9298", Offset = "0x9298", VA = "0x9298")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001AC RID: 428
		// (add) Token: 0x060043E6 RID: 17382 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060043E7 RID: 17383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AC")]
		public event Action<ChatVisitorData, ChatMessageItem> ClickOnVisitorEvent
		{
			[Token(Token = "0x60043E6")]
			[Address(RVA = "0x9299", Offset = "0x9299", VA = "0x9299")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60043E7")]
			[Address(RVA = "0x929A", Offset = "0x929A", VA = "0x929A")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060043E8 RID: 17384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043E8")]
		[Address(RVA = "0x929B", Offset = "0x929B", VA = "0x929B", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Chat_View_Messages_MessagesListAdapter__Start
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  int param1_00;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57b1b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Chat_View_Messages_MessageViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleClickOnUserNickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleDeleteMessageEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleMessageHasBeenViewedEvent__
		              );
		    DAT_ram_00a57b1b = '\x01';
		  }
		  param1_00 = unnamed_function_1417(Gameplay_Chat_View_Messages_MessageViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_00,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar7 = *(int *)(param1_00 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleMessageHasBeenViewedEvent__
		             ,0);
		  if (DAT_ram_00a57b0b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0b = '\x01';
		  }
		  iVar3 = *(int *)(iVar7 + 0x24);
		  while( true ) {
		    iVar4 = 0;
		    iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		    uVar2 = System_Action_ChatMessageItem__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar4 = func_ii_1082(iVar6,System_Action_ChatMessageItem__TypeInfo), iVar4 == 0)) break;
		    iVar4 = func_ii_4329(iVar7 + 0x24,iVar4,iVar3);
		    bVar1 = iVar4 == iVar3;
		    iVar3 = iVar4;
		    if (bVar1) {
		      iVar7 = *(int *)(param1_00 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleDeleteMessageEvent__,0
		                );
		      if (DAT_ram_00a57b0d == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		        DAT_ram_00a57b0d = '\x01';
		      }
		      iVar3 = *(int *)(iVar7 + 0x28);
		      while( true ) {
		        iVar4 = 0;
		        iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		        uVar2 = System_Action_ChatMessageItem__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar4 = func_ii_1082(iVar6,System_Action_ChatMessageItem__TypeInfo), iVar4 == 0)) break;
		        iVar4 = func_ii_4329(iVar7 + 0x28,iVar4,iVar3);
		        bVar1 = iVar4 == iVar3;
		        iVar3 = iVar4;
		        if (bVar1) {
		          iVar7 = *(int *)(param1_00 + 0x14);
		          uVar5 = unnamed_function_1417(System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		          System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                    (uVar5,param1,
		                     Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleClickOnUserNickEvent__
		                     ,0);
		          if (DAT_ram_00a57b0f == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		            DAT_ram_00a57b0f = '\x01';
		          }
		          iVar3 = *(int *)(iVar7 + 0x2c);
		          while( true ) {
		            iVar4 = 0;
		            iVar6 = UnityEngine_UI_Image__set_sprite(iVar3,uVar5,0);
		            uVar2 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		            if ((iVar6 != 0) &&
		               (iVar4 = func_ii_1082(iVar6,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo)
		               , iVar4 == 0)) break;
		            iVar4 = func_ii_4329(iVar7 + 0x2c,iVar4,iVar3);
		            bVar1 = iVar4 == iVar3;
		            iVar3 = iVar4;
		            if (bVar1) {
		              return param1_00;
		            }
		          }
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x060043E9 RID: 17385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60043E9")]
		[Address(RVA = "0x929C", Offset = "0x929C", VA = "0x929C", Slot = "99")]
		protected override MessageViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__CreateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  int iVar6;
		  int iVar7;
		  
		  if (DAT_ram_00a57b1c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleClickOnUserNickEvent__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleDeleteMessageEvent__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleMessageHasBeenViewedEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57b1c = '\x01';
		  }
		  iVar7 = *(int *)(param2 + 0x14);
		  uVar5 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar5,param1,
		             Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleMessageHasBeenViewedEvent__
		             ,0);
		  if (DAT_ram_00a57b0c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b0c = '\x01';
		  }
		  iVar4 = *(int *)(iVar7 + 0x24);
		  while( true ) {
		    iVar3 = 0;
		    iVar6 = func_ii_7048(iVar4,uVar5,0);
		    uVar2 = System_Action_ChatMessageItem__TypeInfo;
		    if ((iVar6 != 0) &&
		       (iVar3 = func_ii_1082(iVar6,System_Action_ChatMessageItem__TypeInfo), iVar3 == 0)) break;
		    iVar3 = func_ii_4329(iVar7 + 0x24,iVar3,iVar4);
		    bVar1 = iVar3 == iVar4;
		    iVar4 = iVar3;
		    if (bVar1) {
		      iVar7 = *(int *)(param2 + 0x14);
		      uVar5 = unnamed_function_1417(System_Action_ChatMessageItem__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleDeleteMessageEvent__,0
		                );
		      if (DAT_ram_00a57b0e == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		        DAT_ram_00a57b0e = '\x01';
		      }
		      iVar4 = *(int *)(iVar7 + 0x28);
		      while( true ) {
		        iVar3 = 0;
		        iVar6 = func_ii_7048(iVar4,uVar5,0);
		        uVar2 = System_Action_ChatMessageItem__TypeInfo;
		        if ((iVar6 != 0) &&
		           (iVar3 = func_ii_1082(iVar6,System_Action_ChatMessageItem__TypeInfo), iVar3 == 0)) break;
		        iVar3 = func_ii_4329(iVar7 + 0x28,iVar3,iVar4);
		        bVar1 = iVar3 == iVar4;
		        iVar4 = iVar3;
		        if (bVar1) {
		          iVar7 = *(int *)(param2 + 0x14);
		          uVar5 = unnamed_function_1417(System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		          System_Runtime_CompilerServices_AsyncVoidMethodBuilder__AwaitUnsafeOnCompleted_UniTask_Awaiter_bool___BossCaptainViewMediator__SetupView_d__8_
		                    (uVar5,param1,
		                     Method_Gameplay_Chat_View_Messages_MessagesListAdapter_HandleClickOnUserNickEvent__
		                     ,0);
		          if (DAT_ram_00a57b10 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		            DAT_ram_00a57b10 = '\x01';
		          }
		          iVar4 = *(int *)(iVar7 + 0x2c);
		          while( true ) {
		            iVar3 = 0;
		            iVar6 = func_ii_7048(iVar4,uVar5,0);
		            uVar2 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		            if ((iVar6 != 0) &&
		               (iVar3 = func_ii_1082(iVar6,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo)
		               , iVar3 == 0)) break;
		            iVar3 = func_ii_4329(iVar7 + 0x2c,iVar3,iVar4);
		            bVar1 = iVar3 == iVar4;
		            iVar4 = iVar3;
		            if (bVar1) {
		              return;
		            }
		          }
		          System_Activator__CreateInstance(iVar6,uVar2);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(iVar6,uVar2);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(iVar6,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x060043EA RID: 17386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x929D", Offset = "0x929D", VA = "0x929D", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(MessageViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xac);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,param3,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060043EB RID: 17387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x929E", Offset = "0x929E", VA = "0x929E")]
		private void HandleClickOnUserNickEvent(ChatVisitorData visitor, ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleClickOnUserNickEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__HandleClickOnUserNickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0xa8);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  return;
		}
		*/

		}

		// Token: 0x060043EC RID: 17388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x929F", Offset = "0x929F", VA = "0x929F")]
		private void HandleDeleteMessageEvent(ChatMessageItem messageItem)
		{
		}

		// Token: 0x060043ED RID: 17389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x92A0", Offset = "0x92A0", VA = "0x92A0")]
		private void HandleMessageHasBeenViewedEvent(ChatMessageItem messageItem)
		{
		/* --- GHIDRA: HandleMessageHasBeenViewedEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__HandleMessageHasBeenViewedEvent
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 param2_00;
		  int iVar1;
		  undefined4 param1_00;
		  int iVar2;
		  
		  if (DAT_ram_00a57b1d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__ScheduleComputeVisibilityTwinPass__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		              );
		    DAT_ram_00a57b1d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                        (param2,*(undefined4 *)(*param2 + 0xe4));
		  iVar1 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,param2_00,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		                    );
		  iVar2 = param2[5];
		  if (iVar1 != *(int *)(iVar2 + 0x30)) {
		    *(int *)(iVar2 + 0x30) = iVar1;
		    Gameplay_Chat_View_Messages_MessageItemRenderer__GetUserMessage(iVar2,iVar2);
		  }
		  iVar2 = **(int **)(iVar1 + 0xc);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                    (*(int **)(iVar1 + 0xc),*(undefined4 *)(iVar2 + 0xe4));
		  if (iVar1 != 0) {
		    Com_TheFallenGames_OSA_Core_OSA_object__object___ResetItems
		              (param1,0,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__ScheduleComputeVisibilityTwinPass__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x060043EE RID: 17390 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x92A1", Offset = "0x92A1", VA = "0x92A1", Slot = "100")]
		protected override void UpdateViewsHolder(MessageViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__UpdateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  int iVar2;
		  
		  if (DAT_ram_00a57b1e == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__OnItemHeightChangedPreTwinPass__
		              );
		    DAT_ram_00a57b1e = '\x01';
		  }
		  piVar1 = *(int **)(*(int *)(*(int *)(param2 + 0x14) + 0x30) + 0xc);
		  iVar2 = *piVar1;
		  (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe8) * 4))(piVar1,0,*(undefined4 *)(iVar2 + 0xec));
		  return;
		}
		*/

		}

		// Token: 0x060043EF RID: 17391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x92A2", Offset = "0x92A2", VA = "0x92A2", Slot = "112")]
		protected override void OnItemHeightChangedPreTwinPass(MessageViewHolder viewsHolder)
		{
		/* --- GHIDRA: OnItemHeightChangedPreTwinPass ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__OnItemHeightChangedPreTwinPass
		               (int param1,undefined4 param2)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57b1f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__RebuildLayoutDueToScrollViewSizeChange__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		              );
		    DAT_ram_00a57b1f = '\x01';
		  }
		  iVar1 = UnityEngine_AndroidJavaObject___GetRawObject
		                    (*(undefined4 *)(param1 + 0xa0),
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		                    );
		  if (0 < iVar1) {
		    do {
		      iVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (*(undefined4 *)(param1 + 0xa0),param2_00,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		                        );
		      iVar3 = **(int **)(iVar2 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                (*(int **)(iVar2 + 0xc),1,*(undefined4 *)(iVar3 + 0xec));
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  Com_TheFallenGames_OSA_Core_OSA_object__object___PostRebuildLayoutDueToScrollViewSizeChange
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__RebuildLayoutDueToScrollViewSizeChange__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060043F0 RID: 17392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x92A3", Offset = "0x92A3", VA = "0x92A3", Slot = "109")]
		protected override void RebuildLayoutDueToScrollViewSizeChange()
		{
		/* --- GHIDRA: RebuildLayoutDueToScrollViewSizeChange ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__RebuildLayoutDueToScrollViewSizeChange
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int param2_00;
		  int iVar3;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a57b20 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__OnEnable__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		              );
		    DAT_ram_00a57b20 = '\x01';
		  }
		  if ((*(int *)(param1 + 0xa0) != 0) &&
		     (iVar1 = UnityEngine_AndroidJavaObject___GetRawObject
		                        (*(int *)(param1 + 0xa0),
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Count__
		                        ), 0 < iVar1)) {
		    do {
		      iVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                        (*(undefined4 *)(param1 + 0xa0),param2_00,
		                         Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__get_Item__
		                        );
		      iVar3 = **(int **)(iVar2 + 0xc);
		      (**(code **)((ulonglong)*(uint *)(iVar3 + 0xe8) * 4))
		                (*(int **)(iVar2 + 0xc),1,*(undefined4 *)(iVar3 + 0xec));
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x92A4", Offset = "0x92A4", VA = "0x92A4", Slot = "68")]
		protected override void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__OnEnable
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int *piVar6;
		  
		  iVar3 = 0;
		  if (DAT_ram_00a57b21 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IList_ChatMessageItem__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__ResetItems__
		              );
		    DAT_ram_00a57b21 = '\x01';
		  }
		  do {
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo == *piVar6) {
		          puVar2 = (uint *)(iVar4 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80e24732;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,
		                                  System_Collections_Generic_ICollection_ChatMessageItem__TypeInfo,0
		                                 );
		code_r0x80e24732:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (iVar4 <= iVar3) {
		      (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))
		                (param1,*(undefined4 *)(*param1 + 0x2ec));
		      Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		                (param1[0x28],param2,0,
		                 Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__ResetItems__
		                );
		      return;
		    }
		    iVar4 = *param2;
		    if (*(ushort *)(iVar4 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar6 = (int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IList_ChatMessageItem__TypeInfo == *piVar6) {
		          puVar2 = (uint *)(iVar4 + piVar6[1] * 8 + 0xc0);
		          goto code_r0x80e247b1;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,System_Collections_Generic_IList_ChatMessageItem__TypeInfo,
		                                  0);
		code_r0x80e247b1:
		    iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(param2,iVar3,puVar2[1]);
		    iVar5 = **(int **)(iVar4 + 0xc);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		              (*(int **)(iVar4 + 0xc),1,*(undefined4 *)(iVar5 + 0xec));
		    iVar3 = iVar3 + 1;
		  } while( true );
		}
		*/

		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F2")]
		[Address(RVA = "0x92A5", Offset = "0x92A5", VA = "0x92A5")]
		public void SetItems(IList<ChatMessageItem> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57b22 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder___ctor__
		              );
		    DAT_ram_00a57b22 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060043F3 RID: 17395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60043F3")]
		[Address(RVA = "0x92A6", Offset = "0x92A6", VA = "0x92A6")]
		public MessagesListAdapter()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Data ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__set_Data
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b14 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b14 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: add_MessageHasBeenViewedEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__add_MessageHasBeenViewedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b15 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b15 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa4);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa4,iVar2,param1_00);
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


		/* --- GHIDRA: remove_MessageHasBeenViewedEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__remove_MessageHasBeenViewedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b16 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b16 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: add_MessageDeleteRequestEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__add_MessageDeleteRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b17 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b17 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatMessageItem__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xa8,iVar2,param1_00);
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


		/* --- GHIDRA: remove_MessageDeleteRequestEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__remove_MessageDeleteRequestEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b18 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b18 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xac);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xac,iVar2,param1_00);
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


		/* --- GHIDRA: add_ClickOnVisitorEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__add_ClickOnVisitorEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b19 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ChatVisitorData__ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b19 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xac);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_ChatVisitorData__ChatMessageItem__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ChatVisitorData__ChatMessageItem__TypeInfo),
		       iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0xac,iVar2,param1_00);
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


		/* --- GHIDRA: remove_ClickOnVisitorEvent ---
		void Gameplay_Chat_View_Messages_MessagesListAdapter__remove_ClickOnVisitorEvent
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b1a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem___ctor__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__TypeInfo);
		    DAT_ram_00a57b1a = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem__TypeInfo
		                          );
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatMessageItem___ctor__);
		    *(undefined4 *)(param1 + 0xa0) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__MessageViewHolder__Start__
		              );
		  }
		  return;
		}
		*/

}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Com.TheFallenGames.OSA.Core;
using Com.TheFallenGames.OSA.CustomParams;
using Com.TheFallenGames.OSA.DataHelpers;
using Gameplay.Chat.Model.Data;
using Il2CppDummyDll;

namespace Gameplay.Chat.View.Bans
{
	// Token: 0x02000B01 RID: 2817
	[Token(Token = "0x2000B01")]
	public class ChatBanListAdapter : OSA<BaseParamsWithPrefab, ChatBanListAdapter.ChatBanViewHolder>
	{
		// Token: 0x140001AE RID: 430
		// (add) Token: 0x06004402 RID: 17410 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004403 RID: 17411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001AE")]
		public event EventHandler<ChatBanArticleData> SelectedEvent
		{
			[Token(Token = "0x6004402")]
			[Address(RVA = "0x92B5", Offset = "0x92B5", VA = "0x92B5")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004403")]
			[Address(RVA = "0x92B6", Offset = "0x92B6", VA = "0x92B6")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06004404 RID: 17412 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004405 RID: 17413 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D63")]
		public SimpleDataHelper<ChatBanArticleData> Data
		{
			[Token(Token = "0x6004404")]
			[Address(RVA = "0x92B7", Offset = "0x92B7", VA = "0x92B7")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004405")]
			[Address(RVA = "0x92B8", Offset = "0x92B8", VA = "0x92B8")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004407 RID: 17415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D64")]
		public ChatBanArticleData SelectedData
		{
			[Token(Token = "0x6004406")]
			[Address(RVA = "0x92B9", Offset = "0x92B9", VA = "0x92B9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004407")]
			[Address(RVA = "0x92BA", Offset = "0x92BA", VA = "0x92BA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004408")]
		[Address(RVA = "0x92BB", Offset = "0x92BB", VA = "0x92BB", Slot = "69")]
		protected override void Start()
		{
		/* --- GHIDRA: Start ---
		int Gameplay_Chat_View_Bans_ChatBanListAdapter__Start
		              (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  undefined4 param1_02;
		  int param1_03;
		  int iVar3;
		  
		  if (DAT_ram_00a57b2b == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanListAdapter_HandleClickEventEvent__);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Chat_View_Bans_ChatBanListAdapter_ChatBanViewHolder_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b2b = '\x01';
		  }
		  param1_01 = unnamed_function_1417
		                        (Gameplay_Chat_View_Bans_ChatBanListAdapter_ChatBanViewHolder_TypeInfo);
		  Com_TheFallenGames_OSA_Core_AbstractViewsHolder__set_ItemIndex
		            (param1_01,*(undefined4 *)(*(int *)(param1 + 0x10) + 0x4c),
		             *(undefined4 *)(*(int *)(param1 + 0x10) + 8),param2,1,1,0);
		  iVar3 = *(int *)(param1_01 + 0x14);
		  param1_02 = unnamed_function_1417(System_EventHandler_ChatBanArticleData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_02,param1,
		             Method_Gameplay_Chat_View_Bans_ChatBanListAdapter_HandleClickEventEvent__,0);
		  if (DAT_ram_00a57b24 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b24 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_03 = UnityEngine_UI_Image__set_sprite(param1_00,param1_02,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_03 != 0) &&
		       (iVar2 = func_ii_1082(param1_03,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(iVar3 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return param1_01;
		    }
		  }
		  System_Activator__CreateInstance(param1_03,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004409 RID: 17417 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004409")]
		[Address(RVA = "0x92BC", Offset = "0x92BC", VA = "0x92BC", Slot = "99")]
		protected override ChatBanListAdapter.ChatBanViewHolder CreateViewsHolder(int itemIndex)
		{
		/* --- GHIDRA: CreateViewsHolder ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__CreateViewsHolder
		               (undefined4 param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int iVar2;
		  int param1_00;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  
		  if (DAT_ram_00a57b2c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Chat_View_Bans_ChatBanListAdapter_HandleClickEventEvent__);
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder__OnBeforeDestroyViewsHolder__
		              );
		    DAT_ram_00a57b2c = '\x01';
		  }
		  iVar3 = *(int *)(param2 + 0x14);
		  param1_01 = unnamed_function_1417(System_EventHandler_ChatBanArticleData__TypeInfo);
		  UnityEngine_Object__Instantiate_object_
		            (param1_01,param1,
		             Method_Gameplay_Chat_View_Bans_ChatBanListAdapter_HandleClickEventEvent__,0);
		  if (DAT_ram_00a57b25 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b25 = '\x01';
		  }
		  param1_00 = *(int *)(iVar3 + 0x20);
		  while( true ) {
		    iVar2 = 0;
		    param1_02 = func_ii_7048(param1_00,param1_01,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_02 != 0) &&
		       (iVar2 = func_ii_1082(param1_02,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(iVar3 + 0x20,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_02,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x0600440A RID: 17418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440A")]
		[Address(RVA = "0x92BD", Offset = "0x92BD", VA = "0x92BD", Slot = "105")]
		protected override void OnBeforeDestroyViewsHolder(ChatBanListAdapter.ChatBanViewHolder vh, bool isActive)
		{
		/* --- GHIDRA: OnBeforeDestroyViewsHolder ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__OnBeforeDestroyViewsHolder
		               (int param1,int *param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int param1_01;
		  
		  if (DAT_ram_00a57b2d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__get_Item__
		              );
		    DAT_ram_00a57b2d = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0xa4);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(*param2 + 0xe0) * 4))
		                    (param2,*(undefined4 *)(*param2 + 0xe4));
		  iVar2 = Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___System_Collections_IEnumerable_GetEnumerator
		                    (param1_00,uVar1,
		                     Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__get_Item__
		                    );
		  param1_01 = param2[5];
		  if (iVar2 == *(int *)(param1_01 + 0x24)) {
		    if (DAT_ram_00a57b26 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		                );
		      DAT_ram_00a57b26 = '\x01';
		      iVar2 = *(int *)(param1_01 + 0x24);
		    }
		    piVar3 = *(int **)(param1_01 + 0x1c);
		    uVar1 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle(*(undefined4 *)(iVar2 + 8),0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  else {
		    *(int *)(param1_01 + 0x24) = iVar2;
		    if (DAT_ram_00a57b26 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		                );
		      DAT_ram_00a57b26 = '\x01';
		      iVar2 = *(int *)(param1_01 + 0x24);
		    }
		    piVar3 = *(int **)(param1_01 + 0x1c);
		    uVar1 = Core_Extensions_Dict_BossCategoryDicExt__GetTitle(*(undefined4 *)(iVar2 + 8),0);
		    iVar2 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x2d0) * 4))
		              (piVar3,uVar1,*(undefined4 *)(iVar2 + 0x2d4));
		  }
		  uVar1 = 2;
		  if (*(char *)(*(int *)(param1_01 + 0x24) + 0xc) == '\0') {
		    uVar1 = 1;
		  }
		  Gameplay_Boss_View_CaptainTab_BossTeamView__set_TeamInfoData
		            (param1_01,uVar1,
		             Method_UI_MonoBehaviourWithStates_ChatBanItemRenderer_ChatBanItemRendererStates__set_CurrentState__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600440B RID: 17419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440B")]
		[Address(RVA = "0x92BE", Offset = "0x92BE", VA = "0x92BE", Slot = "100")]
		protected override void UpdateViewsHolder(ChatBanListAdapter.ChatBanViewHolder newOrRecycled)
		{
		/* --- GHIDRA: UpdateViewsHolder ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__UpdateViewsHolder
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 *puVar3;
		  undefined4 param1_00;
		  int iVar4;
		  int *piVar5;
		  int iVar6;
		  int *piVar7;
		  int local_c;
		  int **local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a57b2e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerable_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_IEnumerator_ChatBanArticleData__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    DAT_ram_00a57b2e = '\x01';
		  }
		  piVar5 = (int *)param1[0x29];
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (System_Collections_Generic_IEnumerable_ChatBanArticleData__TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar6 + *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80e24ff0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,
		                                System_Collections_Generic_IEnumerable_ChatBanArticleData__TypeInfo,
		                                0);
		code_r0x80e24ff0:
		  local_4 = (int *)(**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  local_c = 0;
		  local_8 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e250bf;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x80e251fc:
		      DAT_ram_009d3e38 = 0;
		      param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x80e25204;
		    }
		code_r0x80e250bf:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x80e251fc;
		    if (iVar6 == 0) {
		      iVar6 = 0;
		      goto code_r0x80e2524d;
		    }
		    iVar6 = *local_4;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8);
		        if (System_Collections_Generic_IEnumerator_ChatBanArticleData__TypeInfo == *piVar7) {
		          puVar3 = (undefined4 *)(iVar6 + piVar7[1] * 8 + 0xc0);
		          goto code_r0x80e25199;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar3 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_Generic_IEnumerator_ChatBanArticleData__TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) break;
		code_r0x80e25199:
		    DAT_ram_009d3e38 = 0;
		    iVar6 = import::env::invoke_iii(*puVar3,piVar5,puVar3[1]);
		    if (DAT_ram_009d3e38 == 1) break;
		    *(bool *)(iVar6 + 0xc) = iVar6 == param3;
		  } while( true );
		  DAT_ram_009d3e38 = 0;
		  param1_00 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x80e25204:
		  iVar6 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar6 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(param1_00);
		    iVar6 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    local_c = iVar6;
		    import::env::invoke_v(0x123);
		    iVar4 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar4 != 1) {
		code_r0x80e2524d:
		      piVar5 = local_4;
		      DAT_ram_009d3e38 = 0;
		      if (local_4 != (int *)0x0) {
		        uVar1 = 0;
		        iVar4 = *local_4;
		        if (*(ushort *)(iVar4 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		              puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x80e252c5;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		        }
		        puVar2 = (uint *)func_ii_1080(local_4,System_IDisposable_TypeInfo,0);
		code_r0x80e252c5:
		        (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		      }
		      if (iVar6 == 0) {
		        param1[0x2a] = param3;
		        iVar6 = param1[0x28];
		        (**(code **)((ulonglong)*(uint *)(iVar6 + 0xc) * 4))
		                  (*(undefined4 *)(iVar6 + 0x20),param1,param3,*(undefined4 *)(iVar6 + 0x14));
		        (**(code **)((ulonglong)*(uint *)(*param1 + 0x338) * 4))
		                  (param1,0,0,*(undefined4 *)(*param1 + 0x33c));
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(iVar6);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    param1_00 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x28,&local_c);
		  iVar6 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar6 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(param1_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600440C RID: 17420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440C")]
		[Address(RVA = "0x92BF", Offset = "0x92BF", VA = "0x92BF")]
		private void HandleClickEventEvent(object sender, ChatBanArticleData e)
		{
		/* --- GHIDRA: HandleClickEventEvent ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__HandleClickEventEvent
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  if (DAT_ram_00a57b2f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__ResetItems__
		              );
		    DAT_ram_00a57b2f = '\x01';
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x2e8) * 4))(param1,*(undefined4 *)(*param1 + 0x2ec));
		  Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_object___RemoveOneFromStart
		            (param1[0x29],param2,0,
		             Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__ResetItems__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600440D RID: 17421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440D")]
		[Address(RVA = "0x92C0", Offset = "0x92C0", VA = "0x92C0")]
		public void SetItems(IList<ChatBanArticleData> items)
		{
		/* --- GHIDRA: SetItems ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__SetItems(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57b30 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder___ctor__
		              );
		    DAT_ram_00a57b30 = '\x01';
		  }
		  UI_OSAGenericBase_object__object___set_Data
		            (param1,
		             Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x0600440E RID: 17422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600440E")]
		[Address(RVA = "0x92C1", Offset = "0x92C1", VA = "0x92C1")]
		public ChatBanListAdapter()
		{
		}

		// Token: 0x02000B02 RID: 2818
		[Token(Token = "0x2000B02")]
		public class ChatBanViewHolder : BaseItemViewsHolder
		{
			// Token: 0x17000D65 RID: 3429
			// (get) Token: 0x0600440F RID: 17423 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000D65")]
			public ChatBanItemRenderer ItemRenderer
			{
				[Token(Token = "0x600440F")]
				[Address(RVA = "0x92C2", Offset = "0x92C2", VA = "0x92C2")]
				get
				{
					return null;
				}
			}

			// Token: 0x06004410 RID: 17424 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004410")]
			[Address(RVA = "0x92C3", Offset = "0x92C3", VA = "0x92C3", Slot = "7")]
			public override void CollectViews()
			{
			}

			// Token: 0x06004411 RID: 17425 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004411")]
			[Address(RVA = "0x92C4", Offset = "0x92C4", VA = "0x92C4")]
			public ChatBanViewHolder()
			{
			}

			// Token: 0x0400257C RID: 9596
			[Token(Token = "0x400257C")]
			[FieldOffset(Offset = "0x14")]
			private ChatBanItemRenderer _itemRenderer;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_SelectedEvent ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__add_SelectedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a57b29 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_EventHandler_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b29 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0xa0);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_EventHandler_ChatBanArticleData__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_EventHandler_ChatBanArticleData__TypeInfo), iVar2 == 0
		       )) break;
		    iVar2 = func_ii_4329(param1 + 0xa0,iVar2,param1_00);
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


		/* --- GHIDRA: set_SelectedData ---
		void Gameplay_Chat_View_Bans_ChatBanListAdapter__set_SelectedData(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a57b2a == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder__Start__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder__get_IsInitialized__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__TypeInfo);
		    DAT_ram_00a57b2a = '\x01';
		  }
		  if (*(char *)(param1 + 0x50) == '\0') {
		    param1_00 = unnamed_function_1417
		                          (
		                          Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData__TypeInfo
		                          );
		    System_Collections_Generic_ShortEnumEqualityComparer___Il2CppFullySharedGenericStructType___GetHashCode
		              (param1_00,param1,1,
		               Method_Com_TheFallenGames_OSA_DataHelpers_SimpleDataHelper_ChatBanArticleData___ctor__
		              );
		    *(undefined4 *)(param1 + 0xa4) = param1_00;
		    Com_TheFallenGames_OSA_Core_OSA_object__object___SmoothScrollTo
		              (param1,
		               Method_Com_TheFallenGames_OSA_Core_OSA_BaseParamsWithPrefab__ChatBanListAdapter_ChatBanViewHolder__Start__
		              );
		  }
		  return;
		}
		*/

}

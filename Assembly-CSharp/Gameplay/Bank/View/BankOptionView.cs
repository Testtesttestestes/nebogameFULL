using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Bank.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Rewards;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C3F RID: 3135
	[Token(Token = "0x2000C3F")]
	public class BankOptionView : AbstractDataRenderer<BankOptionViewArgs>, IBankOptionView
	{
		// Token: 0x140001D9 RID: 473
		// (add) Token: 0x06004C5E RID: 19550 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C5F RID: 19551 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001D9")]
		public event Action<IBankOptionView> BuyButtonClickEvent
		{
			[Token(Token = "0x6004C5E")]
			[Address(RVA = "0x9A9F", Offset = "0x9A9F", VA = "0x9A9F")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C5F")]
			[Address(RVA = "0x9AA0", Offset = "0x9AA0", VA = "0x9AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140001DA RID: 474
		// (add) Token: 0x06004C60 RID: 19552 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004C61 RID: 19553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001DA")]
		public event Action<BankOptionView> FaqButtonClickEvent
		{
			[Token(Token = "0x6004C60")]
			[Address(RVA = "0x9AA1", Offset = "0x9AA1", VA = "0x9AA1")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004C61")]
			[Address(RVA = "0x9AA2", Offset = "0x9AA2", VA = "0x9AA2")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000F67 RID: 3943
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F67")]
		public Button FaqButton
		{
			[Token(Token = "0x6004C62")]
			[Address(RVA = "0x9AA3", Offset = "0x9AA3", VA = "0x9AA3")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000F68 RID: 3944
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x0000E0D0 File Offset: 0x0000C2D0
		[Token(Token = "0x17000F68")]
		protected override bool ValidateDataImmediately
		{
			[Token(Token = "0x6004C63")]
			[Address(RVA = "0x9AA4", Offset = "0x9AA4", VA = "0x9AA4", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F69 RID: 3945
		// (get) Token: 0x06004C64 RID: 19556 RVA: 0x0000E0E8 File Offset: 0x0000C2E8
		[Token(Token = "0x17000F69")]
		protected virtual bool ShowFaqButton
		{
			[Token(Token = "0x6004C64")]
			[Address(RVA = "0x9AA5", Offset = "0x9AA5", VA = "0x9AA5", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000F6A RID: 3946
		// (get) Token: 0x06004C65 RID: 19557 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004C66 RID: 19558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000F6A")]
		public BankOptionData BankOptionData
		{
			[Token(Token = "0x6004C65")]
			[Address(RVA = "0x9AA6", Offset = "0x9AA6", VA = "0x9AA6", Slot = "20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004C66")]
			[Address(RVA = "0x9AA7", Offset = "0x9AA7", VA = "0x9AA7", Slot = "21")]
			set
			{
			}
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C67")]
		[Address(RVA = "0x9AA8", Offset = "0x9AA8", VA = "0x9AA8", Slot = "16")]
		protected override void OnDataInvalidated()
		{
		/* --- GHIDRA: OnDataInvalidated ---
		void Gameplay_Bank_View_BankOptionView__OnDataInvalidated(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint param2_00;
		  
		  if (DAT_ram_00a59777 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_AbstractDataRenderer_BankOptionViewArgs__CommitProperties__);
		    DAT_ram_00a59777 = '\x01';
		  }
		  UI_AbstractDataRenderer_object____ctor
		            (param1,Method_UI_AbstractDataRenderer_BankOptionViewArgs__CommitProperties__);
		  if ((char)param1[0x19] != '\0') {
		    *(undefined1 *)(param1 + 0x19) = 0;
		    param1_00 = param1[0xb];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    if (iVar1 == 0) {
		      param2_00 = 0;
		    }
		    else {
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      param2_00 = (uint)(*(char *)(*(int *)(iVar1 + 0xc) + 0x6e) == '\0');
		    }
		    System_Linq_Enumerable__First_object_(param1_00,param2_00,0);
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C68 RID: 19560 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C68")]
		[Address(RVA = "0x9AA9", Offset = "0x9AA9", VA = "0x9AA9", Slot = "5")]
		protected override void CommitProperties()
		{
		/* --- GHIDRA: CommitProperties ---
		void Gameplay_Bank_View_BankOptionView__CommitProperties(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59778 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59778 = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1[0xb] + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,*(undefined4 *)(*param1 + 0x194),0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1[0xc] + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,*(undefined4 *)(*param1 + 0x18c),0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C69 RID: 19561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C69")]
		[Address(RVA = "0x9AAA", Offset = "0x9AAA", VA = "0x9AAA", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_Bank_View_BankOptionView__Awake(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59779 == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a59779 = '\x01';
		  }
		  UI_AbstractDeferredRenderer__OnDisable(param1,0);
		  uVar2 = *(undefined4 *)(param1[0xb] + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,*(undefined4 *)(*param1 + 0x194),0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1[0xc] + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull(uVar1,param1,*(undefined4 *)(*param1 + 0x18c),0);
		  UnityEngine_Events_UnityAction___ctor(uVar2,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C6A RID: 19562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6A")]
		[Address(RVA = "0x9AAB", Offset = "0x9AAB", VA = "0x9AAB", Slot = "8")]
		protected override void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Bank_View_BankOptionView__OnDestroy(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  
		  iVar1 = *(int *)(param1 + 0x54);
		  if (*(char *)(iVar1 + 0x1c) != '\0') {
		    *(undefined1 *)(iVar1 + 0x1c) = 0;
		    iVar2 = **(int **)(iVar1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar2 + 0x130) * 4))
		              (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar2 + 0x134));
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C6B RID: 19563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6B")]
		[Address(RVA = "0x9AAC", Offset = "0x9AAC", VA = "0x9AAC")]
		public void Release()
		{
		/* --- GHIDRA: Release ---
		void Gameplay_Bank_View_BankOptionView__Release(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param2_00;
		  undefined4 *puVar3;
		  uint *puVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  double dVar8;
		  int *piVar9;
		  uint uVar10;
		  longlong local_28;
		  longlong local_20;
		  longlong local_18;
		  int *local_10;
		  int local_8;
		  int *local_4;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5977a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Nullable_int___ctor__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5977a = '\x01';
		  }
		  local_4 = (int *)0x0;
		  local_8 = 0;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 == 0) {
		    return;
		  }
		  iVar6 = param1[9];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId
		            (iVar6,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x44),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xc],0);
		  iVar1 = *param1;
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x180) * 4))
		                        (param1,*(undefined4 *)(iVar1 + 0x184));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,param2_00,0);
		  Gameplay_Bank_View_BankOptionView__HandleDataChanged(param1,iVar1);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0x10],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(int *)(*(int *)(iVar1 + 0xc) + 0x58) != 0),0);
		  iVar6 = param1[0x10];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  UI_Elements_RightPanel_TitleWithLevel__set_Level
		            (iVar6,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x58),0);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0x11],0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(*(int *)(*(int *)(iVar1 + 0xc) + 0x2c) == 3),0);
		  piVar7 = (int *)param1[0x11];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar6 = *piVar7;
		  (**(code **)((ulonglong)*(uint *)(iVar6 + 0x2d0) * 4))
		            (piVar7,*(undefined4 *)(*(int *)(iVar1 + 0xc) + 0x48),*(undefined4 *)(iVar6 + 0x2d4));
		  iVar6 = param1[0x12];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (iVar6,(uint)(0 < *(int *)(*(int *)(iVar1 + 0xc) + 100)),0);
		  iVar1 = *param1;
		  iVar6 = (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(iVar1 + 0x134));
		  if (0 < *(int *)(*(int *)(iVar6 + 0xc) + 100)) {
		    uVar2 = UnityEngine_UI_Selectable__set_interactable(param1[0x12],0);
		    local_4 = (int *)UnityEngine_Transform__set_hasChanged(uVar2,0);
		    local_10 = &local_8;
		    local_18 = ZEXT48(&local_4) << 0x20;
		    do {
		      piVar7 = local_4;
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(iVar1 + piVar9[1] * 8 + 0xc0);
		            goto code_r0x8106530e;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8106558d:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81065595;
		      }
		code_r0x8106530e:
		      DAT_ram_009d3e38 = 0;
		      iVar1 = import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8106558d;
		      if (iVar1 == 0) {
		        iVar5 = 3;
		        goto code_r0x810655e2;
		      }
		      iVar1 = *local_4;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        uVar10 = 0;
		        do {
		          piVar9 = (int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar9) {
		            puVar3 = (undefined4 *)(piVar9[1] * 8 + iVar1 + 200);
		            goto code_r0x810653e8;
		          }
		          uVar10 = uVar10 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar3 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,1);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8106555b:
		        DAT_ram_009d3e38 = 0;
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81065595;
		      }
		code_r0x810653e8:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = (int *)import::env::invoke_iii(*puVar3,piVar7,puVar3[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8106555b;
		      if (piVar7 != (int *)0x0) {
		        if (((uint)*(byte *)(*piVar7 + 0xb8) <
		             (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*piVar7 + 100) +
		                     (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		            UnityEngine_Transform_TypeInfo)) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar7,
		                     UnityEngine_Transform_TypeInfo);
		          iVar5 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar5 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81065595;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      uVar2 = import::env::invoke_iii
		                        (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar7,0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81065595;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x130),param1,*(undefined4 *)(*param1 + 0x134));
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) {
		        uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81065595;
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_viii
		                (s_struct_Uniforms___color__array<v_ram_000013c7 + 0x26d,uVar2,
		                 (uint)(iVar5 < *(int *)(*(int *)(iVar6 + 0xc) + 100)),0);
		      iVar1 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar1 == 1) goto code_r0x81065583;
		      iVar5 = iVar5 + 1;
		    } while( true );
		  }
		code_r0x81065693:
		  Gameplay_Bank_View_BankOptionView__DisplaySticker(param1,iVar1);
		  Gameplay_Bank_View_BankOptionView__StopListenEvents(param1,iVar1);
		  Gameplay_Bank_View_BankOptionView__HandlePriceButton(param1,iVar1);
		  piVar7 = (int *)param1[0x14];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  dVar8 = *(double *)(*(int *)(iVar5 + 0xc) + 0x20);
		  local_20 = 0;
		  if (ABS(dVar8) < 2147483648.0) {
		    iVar5 = (int)dVar8;
		  }
		  else {
		    iVar5 = -0x80000000;
		  }
		  System_Data_SqlTypes_SqlInt32___ctor(&local_20,iVar5,Method_System_Nullable_int___ctor__);
		  iVar5 = *piVar7;
		  local_18 = local_20;
		  local_28 = local_20;
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x138) * 4))
		            (piVar7,&local_28,*(undefined4 *)(iVar5 + 0x13c));
		  iVar1 = param1[0x15];
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar6 = *(int *)(iVar5 + 8);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  uVar2 = *(undefined4 *)(iVar5 + 0xc);
		  if (*(char *)(iVar1 + 0x1c) != '\0') {
		    *(undefined1 *)(iVar1 + 0x1c) = 0;
		    iVar5 = **(int **)(iVar1 + 0x18);
		    (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		              (*(int **)(iVar1 + 0x18),*(undefined4 *)(iVar5 + 0x134));
		    *(undefined4 *)(iVar1 + 0x18) = 0;
		  }
		  if (iVar6 != 0) {
		    Gameplay_Bank_View_BankOptionAdPlacementView__Release(iVar1,iVar6,uVar2,iVar1);
		  }
		  return;
		code_r0x81065583:
		  uVar2 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81065595:
		  iVar5 = global_1;
		  iVar1 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar5 == iVar1) {
		    puVar3 = (undefined4 *)import::env::__cxa_begin_catch(uVar2);
		    iVar5 = 0;
		    DAT_ram_009d3e38 = 0;
		    local_18 = CONCAT44(local_18._4_4_,*puVar3);
		    import::env::invoke_v(0x123);
		    iVar1 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar1 != 1) {
		code_r0x810655e2:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar7 = (int *)*local_10;
		      if (piVar7 != (int *)0x0) {
		        iVar1 = *piVar7;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar10 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8)) {
		              puVar4 = (uint *)(iVar1 + *(int *)(*(int *)(iVar1 + 0x58) + uVar10 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x81065672;
		            }
		            uVar10 = uVar10 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar10);
		        }
		        puVar4 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x81065672:
		        (**(code **)((ulonglong)*puVar4 * 4))(piVar7,puVar4[1]);
		      }
		      if ((int)local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint((int)local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar1 = 0;
		      if (iVar5 != 0) {
		        if (iVar5 == 1) {
		          return;
		        }
		        if (iVar5 == 2) {
		          return;
		        }
		        if (iVar5 != 3) {
		          return;
		        }
		      }
		      goto code_r0x81065693;
		    }
		    uVar2 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x36f,&local_18);
		  iVar5 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar5 != 1) {
		    import::env::__resumeException(uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C6C RID: 19564 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6C")]
		[Address(RVA = "0x9AAD", Offset = "0x9AAD", VA = "0x9AAD", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Bank_View_BankOptionView__HandleDataChanged(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *piVar4;
		  int iVar5;
		  undefined4 uVar6;
		  double dVar7;
		  uint uVar8;
		  float8 local_8;
		  
		  if (DAT_ram_00a5977b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Globalization_CultureInfo_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    DAT_ram_00a5977b = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar1 = *(int *)(*(int *)(iVar1 + 0xc) + 0x28);
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0xb],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar1 == 0),0);
		  if (iVar1 == 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    dVar7 = *(double *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x18) + 8);
		    uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                      (param1[0xe],0);
		    if (0.0 < dVar7) {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,0,0);
		      piVar4 = (int *)param1[0xd];
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      iVar5 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x2d0) * 4))
		                (piVar4,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x18) + 0x18),
		                 *(undefined4 *)(iVar5 + 0x2d4));
		    }
		    else {
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar2,1,0);
		      iVar1 = param1[0xe];
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar8 = 0;
		      piVar4 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar5 = *piVar4;
		      if (*(ushort *)(iVar5 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8)) {
		            puVar3 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar8 * 8 + 4) * 8 + iVar5 + 0x178);
		            goto code_r0x810659b4;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar5 + 0xb6) != uVar8);
		      }
		      puVar3 = (uint *)func_ii_1080(piVar4,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x810659b4:
		      uVar2 = (**(code **)((ulonglong)*puVar3 * 4))(piVar4,puVar3[1]);
		      uVar2 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar2,0);
		      iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar6 = *(undefined4 *)(*(int *)(*(int *)(iVar5 + 0xc) + 0x5c) + 8);
		      if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_MoneyType_TypeInfo);
		      }
		      uVar6 = func_ii_7278(uVar6,0);
		      uVar2 = Core_Extensions_Dict_ResourceSetExt__GetValue(uVar2,uVar6,0);
		      uVar2 = System_Double__ToString(uVar2,0);
		      Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar1,uVar2,0);
		      piVar4 = (int *)param1[0xd];
		      iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      local_8 = *(float8 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x5c) + 0x10);
		      if (*(int *)(System_Globalization_CultureInfo_TypeInfo + 0x74) == 0) {
		        func_ii_306000(System_Globalization_CultureInfo_TypeInfo);
		      }
		      uVar2 = System_Xml_Schema_SchemaCollectionCompiler__GetAnySchemaType(0);
		      uVar2 = System_Double__GetHashCode(&local_8,uVar2,0);
		      iVar1 = *piVar4;
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (piVar4,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C6D RID: 19565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6D")]
		[Address(RVA = "0x9AAE", Offset = "0x9AAE", VA = "0x9AAE")]
		private void HandlePriceButton()
		{
		/* --- GHIDRA: HandlePriceButton ---
		void Gameplay_Bank_View_BankOptionView__HandlePriceButton(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  int *param1_00;
		  int iVar5;
		  
		  if (DAT_ram_00a5977c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    DAT_ram_00a5977c = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  iVar2 = *(int *)(*(int *)(iVar2 + 0xc) + 0x68);
		  uVar3 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[0x13],0);
		  if (iVar2 == 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (uVar3,0,0);
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar3,1,0);
		  iVar2 = param1[0x13];
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar5 = *param1_00;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar4 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 0x178);
		        goto code_r0x8106667b;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8106667b:
		  uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  iVar5 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  uVar3 = Core_Extensions_Dict_DictExt__TryGetAccountDic
		                    (uVar3,*(undefined4 *)(*(int *)(iVar5 + 0xc) + 0x68),0);
		  uVar3 = Core_Extensions_Dict_NotificationGroupDicExt__GetTitle(uVar3,0);
		  Core_Extensions_Dict_PortalDicExt__GetCurrencyIcon60x66(iVar2,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C6E RID: 19566 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6E")]
		[Address(RVA = "0x9AAF", Offset = "0x9AAF", VA = "0x9AAF")]
		private void DisplaySticker()
		{
		/* --- GHIDRA: DisplaySticker ---
		void Gameplay_Bank_View_BankOptionView__DisplaySticker(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  int *piVar5;
		  uint *puVar6;
		  double param4;
		  int iVar7;
		  int iVar8;
		  undefined4 uVar9;
		  undefined4 param1_00;
		  int *piVar10;
		  uint uVar11;
		  int local_18;
		  int **local_14;
		  int *local_10;
		  int *local_c;
		  int local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a5977d == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_Money__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_MoneyType_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Money_Money_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Object_Instantiate_BankOptionResourceProfitView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Transform_TypeInfo);
		    DAT_ram_00a5977d = '\x01';
		  }
		  local_8 = 0;
		  local_c = (int *)0x0;
		  local_4 = (int *)UnityEngine_Transform__set_hasChanged(param1[0xf],0);
		  local_10 = &local_8;
		  local_18 = 0;
		  local_14 = &local_4;
		  do {
		    piVar5 = local_4;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		          goto code_r0x81065bed;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,0);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81065e30:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81065e38;
		    }
		code_r0x81065bed:
		    DAT_ram_009d3e38 = 0;
		    iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    piVar5 = local_4;
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81065e30;
		    if (iVar7 == 0) goto code_r0x81065e81;
		    iVar7 = *local_4;
		    if (*(ushort *)(iVar7 + 0xb6) != 0) {
		      uVar11 = 0;
		      do {
		        piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		        if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		          puVar2 = (undefined4 *)(piVar10[1] * 8 + iVar7 + 200);
		          goto code_r0x81065cca;
		        }
		        uVar11 = uVar11 + 1;
		      } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		    }
		    DAT_ram_009d3e38 = 0;
		    puVar2 = (undefined4 *)
		             import::env::invoke_iiii
		                       (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                        System_Collections_IEnumerator_TypeInfo,1);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81065e12:
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81065e38;
		    }
		code_r0x81065cca:
		    DAT_ram_009d3e38 = 0;
		    piVar5 = (int *)import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81065e12;
		    if (piVar5 != (int *)0x0) {
		      if (((uint)*(byte *)(*piVar5 + 0xb8) < (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8))
		         || (*(int *)(*(int *)(*piVar5 + 100) +
		                      (uint)*(byte *)(UnityEngine_Transform_TypeInfo + 0xb8) * 4 + -4) !=
		             UnityEngine_Transform_TypeInfo)) {
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_vii
		                  (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,piVar5,
		                   UnityEngine_Transform_TypeInfo);
		        iVar7 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar7 != 1) {
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81065e38;
		      }
		    }
		    DAT_ram_009d3e38 = 0;
		    uVar3 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x25c,piVar5,0);
		    if (DAT_ram_009d3e38 == 1) break;
		    if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi
		                (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,UnityEngine_Object_TypeInfo
		                );
		      if (DAT_ram_009d3e38 == 1) break;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_vii(s_struct_Uniforms___color__array<v_ram_00000aff + 0x274,uVar3,0);
		  } while (DAT_ram_009d3e38 != 1);
		  DAT_ram_009d3e38 = 0;
		  uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81065e38:
		  iVar7 = global_1;
		  iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar7 == iVar4) {
		    piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		    local_18 = *piVar5;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar7 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar7 != 1) {
		code_r0x81065e81:
		      DAT_ram_009d3e38 = 0;
		      local_8 = func_ii_1082(local_4,System_IDisposable_TypeInfo);
		      piVar5 = (int *)*local_10;
		      if (piVar5 != (int *)0x0) {
		        iVar7 = *piVar5;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8)) {
		              puVar6 = (uint *)(iVar7 + *(int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8 + 4) * 8 + 0xc0
		                               );
		              goto code_r0x81065f11;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        puVar6 = (uint *)func_ii_1080(piVar5,System_IDisposable_TypeInfo,0);
		code_r0x81065f11:
		        (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		      }
		      if (local_18 != 0) {
		        System_Data_DataSet__ValidateLocaleConstraint(local_18);
		        do {
		          halt_trap();
		        } while( true );
		      }
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      if (*(int *)(*(int *)(iVar7 + 0xc) + 0x34) == 0) {
		        return;
		      }
		      iVar7 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x134));
		      uVar3 = *(undefined4 *)(*(int *)(*(int *)(iVar7 + 0xc) + 0x34) + 0xc);
		      if (*(int *)(Core_Money_Money_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_Money_Money_TypeInfo);
		      }
		      local_c = (int *)Core_Money_Money__op_Explicit(uVar3,0);
		      local_18 = 0;
		      local_14 = &local_c;
		      do {
		        piVar5 = local_c;
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		            if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x81066087;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_IEnumerator_TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81066399:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810663a1;
		        }
		code_r0x81066087:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        piVar5 = local_c;
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81066399;
		        if (iVar7 == 0) {
		          iVar7 = 0;
		          goto code_r0x810663ea;
		        }
		        iVar7 = *local_c;
		        if (*(ushort *)(iVar7 + 0xb6) != 0) {
		          uVar11 = 0;
		          do {
		            piVar10 = (int *)(*(int *)(iVar7 + 0x58) + uVar11 * 8);
		            if (System_Collections_Generic_IEnumerator_Money__TypeInfo == *piVar10) {
		              puVar2 = (undefined4 *)(iVar7 + piVar10[1] * 8 + 0xc0);
		              goto code_r0x81066161;
		            }
		            uVar11 = uVar11 + 1;
		          } while (*(ushort *)(iVar7 + 0xb6) != uVar11);
		        }
		        DAT_ram_009d3e38 = 0;
		        puVar2 = (undefined4 *)
		                 import::env::invoke_iiii
		                           (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_c,
		                            System_Collections_Generic_IEnumerator_Money__TypeInfo,0);
		        if (DAT_ram_009d3e38 == 1) {
		code_r0x81066353:
		          DAT_ram_009d3e38 = 0;
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810663a1;
		        }
		code_r0x81066161:
		        DAT_ram_009d3e38 = 0;
		        iVar7 = import::env::invoke_iii(*puVar2,piVar5,puVar2[1]);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81066353;
		        iVar4 = param1[0xf];
		        iVar8 = param1[0x16];
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     UnityEngine_Object_TypeInfo);
		          iVar1 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar1 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810663a1;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar3 = import::env::invoke_iiii
		                          (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x2ce,iVar8,iVar4,
		                           Method_UnityEngine_Object_Instantiate_BankOptionResourceProfitView___);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810663a1;
		        }
		        DAT_ram_009d3e38 = 0;
		        iVar8 = import::env::invoke_iii
		                          (*(undefined4 *)(*param1 + 0x130),param1,*(undefined4 *)(*param1 + 0x134))
		        ;
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810663a1;
		        }
		        uVar9 = *(undefined4 *)(iVar7 + 8);
		        param1_00 = *(undefined4 *)(*(int *)(*(int *)(iVar8 + 0xc) + 0x34) + 0x10);
		        if (*(int *)(Core_Money_Money_MoneyType_TypeInfo + 0x74) == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vi
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x180,
		                     Core_Money_Money_MoneyType_TypeInfo);
		          iVar4 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar4 == 1) {
		            uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		            goto code_r0x810663a1;
		          }
		        }
		        DAT_ram_009d3e38 = 0;
		        uVar9 = func_ii_7278(uVar9,0);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 == 1) {
		          uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x810663a1;
		        }
		        DAT_ram_009d3e38 = 0;
		        param4 = func_ii_6906(param1_00,uVar9,0);
		        if (DAT_ram_009d3e38 == 1) break;
		        DAT_ram_009d3e38 = 0;
		        import::env::invoke_viidi
		                  (s_struct_Uniforms___color__array<v_ram_00001b87 + 0x371,uVar3,iVar7,param4,iVar7)
		        ;
		      } while (DAT_ram_009d3e38 != 1);
		      DAT_ram_009d3e38 = 0;
		      uVar3 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x810663a1:
		      iVar7 = global_1;
		      iVar4 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar7 == iVar4) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar3);
		        iVar7 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_18 = iVar7;
		        import::env::invoke_v(0x123);
		        iVar4 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar4 != 1) {
		code_r0x810663ea:
		          piVar5 = local_c;
		          DAT_ram_009d3e38 = 0;
		          if (local_c != (int *)0x0) {
		            uVar11 = 0;
		            iVar4 = *local_c;
		            if (*(ushort *)(iVar4 + 0xb6) != 0) {
		              do {
		                if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8)) {
		                  puVar6 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar11 * 8 + 4) * 8 +
		                                   0xc0);
		                  goto code_r0x81066462;
		                }
		                uVar11 = uVar11 + 1;
		              } while (*(ushort *)(iVar4 + 0xb6) != uVar11);
		            }
		            puVar6 = (uint *)func_ii_1080(local_c,System_IDisposable_TypeInfo,0);
		code_r0x81066462:
		            (**(code **)((ulonglong)*puVar6 * 4))(piVar5,puVar6[1]);
		          }
		          if (iVar7 == 0) {
		            return;
		          }
		          System_Data_DataSet__ValidateLocaleConstraint(iVar7);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        uVar3 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x372,&local_18);
		      goto joined_r0x810664b1;
		    }
		    uVar3 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001b87 + 0x370,&local_18);
		joined_r0x810664b1:
		  if (DAT_ram_009d3e38 != 1) {
		    DAT_ram_009d3e38 = 0;
		    import::env::__resumeException(uVar3);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::__cxa_find_matching_catch_3(0);
		  unnamed_function_937();
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C6F RID: 19567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C6F")]
		[Address(RVA = "0x9AB0", Offset = "0x9AB0", VA = "0x9AB0")]
		private void DisplayResourceProfit()
		{
		/* --- GHIDRA: DisplayResourceProfit ---
		void Gameplay_Bank_View_BankOptionView__DisplayResourceProfit
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5977e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionView_BankOptionDataOnIsProcessingChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_DisplayResourceProfit__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_DisplaySticker__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_RenderRewards__);
		    DAT_ram_00a5977e = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Bank_View_BankOptionView_BankOptionDataOnIsProcessingChangedEvent__,0);
		  if (DAT_ram_00a597c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c5 = '\x01';
		  }
		  iVar2 = *(int *)(iVar6 + 0x10);
		  while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0), piVar4 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar4))) {
		    iVar5 = func_ii_4329(iVar6 + 0x10,piVar4,iVar2);
		    bVar1 = iVar5 == iVar2;
		    iVar2 = iVar5;
		    if (bVar1) {
		      iVar6 = *(int *)(param2 + 0xc);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_RenderRewards__,0);
		      if (DAT_ram_00a597c1 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a597c1 = '\x01';
		      }
		      iVar2 = *(int *)(iVar6 + 8);
		      while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0), piVar4 == (int *)0x0
		             || (System_Action_TypeInfo == *piVar4))) {
		        iVar5 = func_ii_4329(iVar6 + 8,piVar4,iVar2);
		        bVar1 = iVar5 == iVar2;
		        iVar2 = iVar5;
		        if (bVar1) {
		          iVar6 = *(int *)(param2 + 0xc);
		          uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		          UnityEngine_Events_UnityEvent__AddListener
		                    (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_DisplayResourceProfit__,0
		                    );
		          if (DAT_ram_00a597c3 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		            DAT_ram_00a597c3 = '\x01';
		          }
		          iVar2 = *(int *)(iVar6 + 0xc);
		          while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0),
		                 piVar4 == (int *)0x0 || (System_Action_TypeInfo == *piVar4))) {
		            iVar5 = func_ii_4329(iVar6 + 0xc,piVar4,iVar2);
		            bVar1 = iVar5 == iVar2;
		            iVar2 = iVar5;
		            if (bVar1) {
		              iVar6 = *(int *)(param2 + 0xc);
		              uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		              UnityEngine_Events_UnityEvent__AddListener
		                        (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_DisplaySticker__,0);
		              if (DAT_ram_00a597c7 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		                DAT_ram_00a597c7 = '\x01';
		              }
		              iVar2 = *(int *)(iVar6 + 0x14);
		              while ((piVar4 = (int *)UnityEngine_UI_Image__set_sprite(iVar2,uVar3,0),
		                     piVar4 == (int *)0x0 || (System_Action_TypeInfo == *piVar4))) {
		                iVar5 = func_ii_4329(iVar6 + 0x14,piVar4,iVar2);
		                bVar1 = iVar5 == iVar2;
		                iVar2 = iVar5;
		                if (bVar1) {
		                  return;
		                }
		              }
		              System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C70 RID: 19568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C70")]
		[Address(RVA = "0x9AB1", Offset = "0x9AB1", VA = "0x9AB1", Slot = "17")]
		protected override void StartListenEvents(BankOptionViewArgs args)
		{
		/* --- GHIDRA: StartListenEvents ---
		void Gameplay_Bank_View_BankOptionView__StartListenEvents
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  int iVar6;
		  
		  if (DAT_ram_00a5977f == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Bank_View_BankOptionView_BankOptionDataOnIsProcessingChangedEvent__)
		    ;
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_DisplayResourceProfit__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_DisplaySticker__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Bank_View_BankOptionView_RenderRewards__);
		    DAT_ram_00a5977f = '\x01';
		  }
		  iVar6 = *(int *)(param2 + 0xc);
		  uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar3,param1,
		             Method_Gameplay_Bank_View_BankOptionView_BankOptionDataOnIsProcessingChangedEvent__,0);
		  if (DAT_ram_00a597c6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a597c6 = '\x01';
		  }
		  iVar2 = *(int *)(iVar6 + 0x10);
		  while ((piVar4 = (int *)func_ii_7048(iVar2,uVar3,0), piVar4 == (int *)0x0 ||
		         (System_Action_TypeInfo == *piVar4))) {
		    iVar5 = func_ii_4329(iVar6 + 0x10,piVar4,iVar2);
		    bVar1 = iVar5 == iVar2;
		    iVar2 = iVar5;
		    if (bVar1) {
		      iVar6 = *(int *)(param2 + 0xc);
		      uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		      UnityEngine_Events_UnityEvent__AddListener
		                (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_RenderRewards__,0);
		      if (DAT_ram_00a597c2 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		        DAT_ram_00a597c2 = '\x01';
		      }
		      iVar2 = *(int *)(iVar6 + 8);
		      while ((piVar4 = (int *)func_ii_7048(iVar2,uVar3,0), piVar4 == (int *)0x0 ||
		             (System_Action_TypeInfo == *piVar4))) {
		        iVar5 = func_ii_4329(iVar6 + 8,piVar4,iVar2);
		        bVar1 = iVar5 == iVar2;
		        iVar2 = iVar5;
		        if (bVar1) {
		          iVar6 = *(int *)(param2 + 0xc);
		          uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		          UnityEngine_Events_UnityEvent__AddListener
		                    (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_DisplayResourceProfit__,0
		                    );
		          if (DAT_ram_00a597c4 == '\0') {
		            Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		            DAT_ram_00a597c4 = '\x01';
		          }
		          iVar2 = *(int *)(iVar6 + 0xc);
		          while ((piVar4 = (int *)func_ii_7048(iVar2,uVar3,0), piVar4 == (int *)0x0 ||
		                 (System_Action_TypeInfo == *piVar4))) {
		            iVar5 = func_ii_4329(iVar6 + 0xc,piVar4,iVar2);
		            bVar1 = iVar5 == iVar2;
		            iVar2 = iVar5;
		            if (bVar1) {
		              iVar6 = *(int *)(param2 + 0xc);
		              uVar3 = unnamed_function_1417(System_Action_TypeInfo);
		              UnityEngine_Events_UnityEvent__AddListener
		                        (uVar3,param1,Method_Gameplay_Bank_View_BankOptionView_DisplaySticker__,0);
		              if (DAT_ram_00a597c8 == '\0') {
		                Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		                DAT_ram_00a597c8 = '\x01';
		              }
		              iVar2 = *(int *)(iVar6 + 0x14);
		              while ((piVar4 = (int *)func_ii_7048(iVar2,uVar3,0), piVar4 == (int *)0x0 ||
		                     (System_Action_TypeInfo == *piVar4))) {
		                iVar5 = func_ii_4329(iVar6 + 0x14,piVar4,iVar2);
		                bVar1 = iVar5 == iVar2;
		                iVar2 = iVar5;
		                if (bVar1) {
		                  return;
		                }
		              }
		              System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		              do {
		                halt_trap();
		              } while( true );
		            }
		          }
		          System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		      }
		      System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  System_Activator__CreateInstance(piVar4,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x06004C71 RID: 19569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C71")]
		[Address(RVA = "0x9AB2", Offset = "0x9AB2", VA = "0x9AB2", Slot = "18")]
		protected override void StopListenEvents(BankOptionViewArgs args)
		{
		/* --- GHIDRA: StopListenEvents ---
		void Gameplay_Bank_View_BankOptionView__StopListenEvents(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a59780 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    DAT_ram_00a59780 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (*(int *)(*(int *)(iVar1 + 0xc) + 0x3c) != 0) {
		    param1_00 = param1[10];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x3c) + 0x10);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(uVar2,0);
		    UI_Rewards_AbstractRewardsRender__get_Rewards(param1_00,uVar2,0);
		    iVar1 = *(int *)param1[10];
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		              ((int *)param1[10],*(undefined4 *)(iVar1 + 0xf4));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C72 RID: 19570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C72")]
		[Address(RVA = "0x9AB3", Offset = "0x9AB3", VA = "0x9AB3")]
		private void RenderRewards()
		{
		/* --- GHIDRA: RenderRewards ---
		void Gameplay_Bank_View_BankOptionView__RenderRewards(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param3;
		  undefined1 local_5;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a59781 == '\0') {
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_3782);
		    DAT_ram_00a59781 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  local_4 = *(undefined4 *)(*(int *)(*(int *)(iVar1 + 0xc) + 0x38) + 0xc);
		  uVar2 = func_ii_1081(DAT_ram_00a66958,&local_4);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  local_5 = *(undefined1 *)(*(int *)(iVar1 + 0xc) + 0x6e);
		  param3 = func_ii_1081(DAT_ram_00a66944,&local_5);
		  uVar2 = System_Collections_Generic_Dictionary_int__object___ContainsKey
		                    (StringLiteral_3782,uVar2,param3,0);
		  if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		    func_ii_306000(OKG_Logs_Debug_TypeInfo);
		  }
		  System_Collections_Generic_Dictionary_uint__object___get_Count(uVar2,0);
		  *(undefined1 *)(param1 + 0x19) = 1;
		  UI_AbstractDeferredRenderer__KillCoroutine(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C73 RID: 19571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C73")]
		[Address(RVA = "0x9AB4", Offset = "0x9AB4", VA = "0x9AB4")]
		private void BankOptionDataOnIsProcessingChangedEvent()
		{
		/* --- GHIDRA: BankOptionDataOnIsProcessingChangedEvent ---
		void Gameplay_Bank_View_BankOptionView__BankOptionDataOnIsProcessingChangedEvent
		               (int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param1_00;
		  uint param2_00;
		  
		  param1_00 = param1[0xb];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 == 0) {
		    param2_00 = 0;
		  }
		  else {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    param2_00 = (uint)(*(char *)(*(int *)(iVar1 + 0xc) + 0x6e) == '\0');
		  }
		  System_Linq_Enumerable__First_object_(param1_00,param2_00,0);
		  return;
		}
		*/

		}

		// Token: 0x06004C74 RID: 19572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C74")]
		[Address(RVA = "0x9AB5", Offset = "0x9AB5", VA = "0x9AB5")]
		private void ValidateBuyButtonInteractable()
		{
		/* --- GHIDRA: ValidateBuyButtonInteractable ---
		void Gameplay_Bank_View_BankOptionView__ValidateBuyButtonInteractable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x60);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C75 RID: 19573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C75")]
		[Address(RVA = "0x9AB6", Offset = "0x9AB6", VA = "0x9AB6", Slot = "25")]
		protected virtual void FaqButtonClickHandler()
		{
		/* --- GHIDRA: FaqButtonClickHandler ---
		void Gameplay_Bank_View_BankOptionView__FaqButtonClickHandler(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x5c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06004C76 RID: 19574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C76")]
		[Address(RVA = "0x9AB7", Offset = "0x9AB7", VA = "0x9AB7", Slot = "26")]
		protected virtual void BuyButtonClickHandler()
		{
		/* --- GHIDRA: BuyButtonClickHandler ---
		void Gameplay_Bank_View_BankOptionView__BuyButtonClickHandler
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59771 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59771 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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

		}

		// Token: 0x06004C77 RID: 19575 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C77")]
		[Address(RVA = "0x9AB8", Offset = "0x9AB8", VA = "0x9AB8", Slot = "22")]
		public void AddBuyButtonListener(Action<IBankOptionView> callback)
		{
		/* --- GHIDRA: AddBuyButtonListener ---
		void Gameplay_Bank_View_BankOptionView__AddBuyButtonListener
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59772 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59772 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x5c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_IBankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x5c,iVar2,param1_00);
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

		}

		// Token: 0x06004C78 RID: 19576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C78")]
		[Address(RVA = "0x9AB9", Offset = "0x9AB9", VA = "0x9AB9", Slot = "23")]
		public void RemoveBuyButtonListener(Action<IBankOptionView> callback)
		{
		/* --- GHIDRA: RemoveBuyButtonListener ---
		void Gameplay_Bank_View_BankOptionView__RemoveBuyButtonListener(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59782 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_BankOptionViewArgs___ctor__);
		    DAT_ram_00a59782 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_BankOptionViewArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004C79 RID: 19577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004C79")]
		[Address(RVA = "0x9ABA", Offset = "0x9ABA", VA = "0x9ABA")]
		public BankOptionView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Bank_View_BankOptionView___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59783 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IBankOptionView__TypeInfo);
		    DAT_ram_00a59783 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IBankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IBankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x30,iVar2,param1_00);
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

		}

		// Token: 0x040029AD RID: 10669
		[Token(Token = "0x40029AD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameAssetViewRawImage _bgGameRawImage;

		// Token: 0x040029AE RID: 10670
		[Token(Token = "0x40029AE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x040029AF RID: 10671
		[Token(Token = "0x40029AF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _buyButton;

		// Token: 0x040029B0 RID: 10672
		[Token(Token = "0x40029B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Button _faqButton;

		// Token: 0x040029B1 RID: 10673
		[Token(Token = "0x40029B1")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _buyButtonText;

		// Token: 0x040029B2 RID: 10674
		[Token(Token = "0x40029B2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameRawImage _buyButtonIcon;

		// Token: 0x040029B3 RID: 10675
		[Token(Token = "0x40029B3")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Transform _profitContainer;

		// Token: 0x040029B4 RID: 10676
		[Token(Token = "0x40029B4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x040029B5 RID: 10677
		[Token(Token = "0x40029B5")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TextMeshProUGUI _optionTitle;

		// Token: 0x040029B6 RID: 10678
		[Token(Token = "0x40029B6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _starsContainer;

		// Token: 0x040029B7 RID: 10679
		[Token(Token = "0x40029B7")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private GameRawImage _markerView;

		// Token: 0x040029B8 RID: 10680
		[Token(Token = "0x40029B8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private VipPointsView _vipPointsView;

		// Token: 0x040029B9 RID: 10681
		[Token(Token = "0x40029B9")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private BankOptionAdPlacementView _adPlacementView;

		// Token: 0x040029BA RID: 10682
		[Token(Token = "0x40029BA")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BankOptionResourceProfitView resourceProfitPrefab;

		// Token: 0x040029BD RID: 10685
		[Token(Token = "0x40029BD")]
		[FieldOffset(Offset = "0x64")]
		private bool _isProcessingChanged;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: remove_BuyButtonClickEvent ---
		void Gameplay_Bank_View_BankOptionView__remove_BuyButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59773 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    DAT_ram_00a59773 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_BankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: add_FaqButtonClickEvent ---
		void Gameplay_Bank_View_BankOptionView__add_FaqButtonClickEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a59774 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_BankOptionView__TypeInfo);
		    DAT_ram_00a59774 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x60);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_BankOptionView__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_BankOptionView__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x60,iVar2,param1_00);
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


		/* --- GHIDRA: get_ValidateDataImmediately ---
		uint Gameplay_Bank_View_BankOptionView__get_ValidateDataImmediately(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  return (uint)(*(int *)(*(int *)(iVar1 + 0xc) + 0x2c) == 3);
		}
		*/


		/* --- GHIDRA: get_ShowFaqButton ---
		undefined4 Gameplay_Bank_View_BankOptionView__get_ShowFaqButton(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  return *(undefined4 *)(iVar1 + 0xc);
		}
		*/


		/* --- GHIDRA: get_BankOptionData ---
		void Gameplay_Bank_View_BankOptionView__get_BankOptionData
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a59775 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Bank_Model_BankOptionViewArgs_TypeInfo);
		    DAT_ram_00a59775 = '\x01';
		  }
		  iVar1 = unnamed_function_1417(Gameplay_Bank_Model_BankOptionViewArgs_TypeInfo);
		  *(undefined4 *)(iVar1 + 8) = 0;
		  *(undefined4 *)(iVar1 + 0xc) = param2;
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0x138) * 4))
		            (param1,iVar1,*(undefined4 *)(*param1 + 0x13c));
		  return;
		}
		*/


		/* --- GHIDRA: set_BankOptionData ---
		void Gameplay_Bank_View_BankOptionView__set_BankOptionData(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a59776 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_AbstractDataRenderer_BankOptionViewArgs__OnDataInvalidated__);
		    DAT_ram_00a59776 = '\x01';
		  }
		  *(undefined1 *)(param1 + 100) = 1;
		  return;
		}
		*/

}

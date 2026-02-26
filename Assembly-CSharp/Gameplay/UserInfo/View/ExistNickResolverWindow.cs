using System;
using System.Collections.Generic;
using Google.Protobuf.Collections;
using Il2CppDummyDll;
using Protocol.Auth2;
using UI.Windows;
using UnityEngine;

namespace Gameplay.UserInfo.View
{
	// Token: 0x020003F6 RID: 1014
	[Token(Token = "0x20003F6")]
	public class ExistNickResolverWindow : BaseDialogWindow<ExistNickResolverWindow.ExistNickResolveWindowArgs>
	{
		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000425")]
		public override string WindowId
		{
			[Token(Token = "0x60017CC")]
			[Address(RVA = "0x6987", Offset = "0x6987", VA = "0x6987", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CD")]
		[Address(RVA = "0x6988", Offset = "0x6988", VA = "0x6988", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__HandleContent(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598d5 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_DescriptionField__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_string__string__TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_25589);
		    DAT_ram_00a598d5 = '\x01';
		  }
		  piVar3 = *(int **)(param1 + 0x3c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		                      );
		  param1_00 = *(undefined4 *)(iVar1 + 0x1c);
		  uVar2 = unnamed_function_1417(System_Collections_Generic_Dictionary_string__string__TypeInfo);
		  System_Collections_Generic_Dictionary_object__StyleComplexSelector_PseudoStateData___set_Item
		            (uVar2,Method_System_Collections_Generic_Dictionary_string__string___ctor__);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		                      );
		  System_Reflection_FieldInfo__get_IsStatic
		            (uVar2,StringLiteral_25589,*(undefined4 *)(iVar1 + 0x2c),
		             Method_System_Collections_Generic_Dictionary_string__string__Add__);
		  uVar2 = Core_GameLocalization__GetTranslation(param1_00,uVar2,0);
		  iVar1 = *piVar3;
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		            (piVar3,uVar2,*(undefined4 *)(iVar1 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x060017CE RID: 6094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CE")]
		[Address(RVA = "0x6989", Offset = "0x6989", VA = "0x6989", Slot = "27")]
		protected override void HandleDescription()
		{
		/* --- GHIDRA: HandleDescription ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__HandleDescription(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param3;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int local_20;
		  undefined1 *puStack_1c;
		  undefined8 local_18;
		  undefined1 local_10 [8];
		  undefined8 local_8;
		  
		  if (DAT_ram_00a598d6 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__OnClose__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NickVariantItemRow__Dispose__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NickVariantItemRow__MoveNext__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_Enumerator_NickVariantItemRow__get_Current__)
		    ;
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_ExistNickResolverWindow_HandleConfirmButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NickVariantItemRow__Clear__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NickVariantItemRow__GetEnumerator__);
		    DAT_ram_00a598d6 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleTitle
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__OnClose__
		            );
		  System_Collections_Generic_List_RegexCharClass_SingleRange___ForEach
		            (&local_20,*(undefined4 *)(param1 + 0x58),
		             Method_System_Collections_Generic_List_NickVariantItemRow__GetEnumerator__);
		  local_8 = local_18;
		  local_20 = 0;
		  puStack_1c = local_10;
		  do {
		    DAT_ram_009d3e38 = 0;
		    iVar2 = import::env::invoke_iii
		                      (s_struct_Uniforms___color__array<v_ram_00000aff + 0x44,local_10,
		                       Method_System_Collections_Generic_List_Enumerator_NickVariantItemRow__MoveNext__
		                      );
		    iVar6 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar6 == 1) {
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x81088dcf:
		      iVar6 = global_1;
		      iVar2 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		      if (iVar6 == iVar2) {
		        piVar5 = (int *)import::env::__cxa_begin_catch(uVar4);
		        iVar2 = *piVar5;
		        DAT_ram_009d3e38 = 0;
		        local_20 = iVar2;
		        import::env::invoke_v(0x123);
		        iVar6 = DAT_ram_009d3e38;
		        DAT_ram_009d3e38 = 0;
		        if (iVar6 != 1) {
		          if (iVar2 != 0) {
		            System_Data_DataSet__ValidateLocaleConstraint(iVar2);
		            do {
		              halt_trap();
		            } while( true );
		          }
		code_r0x81088e7e:
		          DAT_ram_009d3e38 = 0;
		          iVar6 = *(int *)(param1 + 0x58);
		          iVar2 = *(int *)(iVar6 + 0xc);
		          *(undefined4 *)(iVar6 + 0xc) = 0;
		          *(int *)(iVar6 + 0x10) = *(int *)(iVar6 + 0x10) + 1;
		          if (0 < iVar2) {
		            func_ii_2064(*(undefined4 *)(iVar6 + 8),0,iVar2,0);
		          }
		          return;
		        }
		        uVar4 = import::env::__cxa_find_matching_catch_2();
		      }
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_ii(s_struct_Uniforms___color__array<v_ram_00001f04 + 0x2e,&local_20);
		      iVar6 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        import::env::__cxa_find_matching_catch_3(0);
		        unnamed_function_937();
		        do {
		          halt_trap();
		        } while( true );
		      }
		      import::env::__resumeException(uVar4);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    if (iVar2 == 0) goto code_r0x81088e7e;
		    DAT_ram_009d3e38 = 0;
		    iVar6 = local_8._4_4_;
		    uVar4 = import::env::invoke_ii
		                      (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x199,
		                       System_Action_string__TypeInfo);
		    if (DAT_ram_009d3e38 == 1) {
		code_r0x81088dc7:
		      DAT_ram_009d3e38 = 0;
		      uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		      goto code_r0x81088dcf;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viiii
		              (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x241,uVar4,param1,
		               Method_Gameplay_UserInfo_View_ExistNickResolverWindow_HandleConfirmButtonOnClickEvent__
		               ,0);
		    if (DAT_ram_009d3e38 == 1) goto code_r0x81088dc7;
		    if (DAT_ram_00a598e1 == '\0') {
		      DAT_ram_009d3e38 = 0;
		      import::env::invoke_vi(0x7ff,&System_Action_string__TypeInfo);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81088dc7;
		      DAT_ram_00a598e1 = '\x01';
		    }
		    iVar2 = *(int *)(iVar6 + 0x18);
		    do {
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iiii
		                        (s_struct_Uniforms___color__array<v_ram_00001b87 + 2,iVar2,uVar4,0);
		      param3 = System_Action_string__TypeInfo;
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x81088db3:
		        DAT_ram_009d3e38 = 0;
		        uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x81088dcf;
		      }
		      if (iVar3 == 0) {
		        param2_00 = 0;
		      }
		      else {
		        DAT_ram_009d3e38 = 0;
		        param2_00 = import::env::invoke_iii
		                              (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x1a,iVar3,
		                               System_Action_string__TypeInfo);
		        if (DAT_ram_009d3e38 == 1) goto code_r0x81088db3;
		        if (param2_00 == 0) {
		          DAT_ram_009d3e38 = 0;
		          import::env::invoke_vii
		                    (s_var<private>_posTex__array<vec4<_ram_00000655 + 0x183,iVar3,param3);
		          iVar6 = DAT_ram_009d3e38;
		          DAT_ram_009d3e38 = 0;
		          if (iVar6 != 1) {
		            do {
		              halt_trap();
		            } while( true );
		          }
		          uVar4 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		          goto code_r0x81088dcf;
		        }
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar3 = func_ii_4329(iVar6 + 0x18,param2_00,iVar2);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x81088db3;
		      bVar1 = iVar2 != iVar3;
		      iVar2 = iVar3;
		    } while (bVar1);
		  } while( true );
		}
		*/

		}

		// Token: 0x060017CF RID: 6095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017CF")]
		[Address(RVA = "0x698A", Offset = "0x698A", VA = "0x698A", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000426")]
		public RepeatedField<string> NickVariants
		{
			[Token(Token = "0x60017D0")]
			[Address(RVA = "0x698B", Offset = "0x698B", VA = "0x698B")]
			get
			{
				return null;
			}
			[Token(Token = "0x60017D1")]
			[Address(RVA = "0x698C", Offset = "0x698C", VA = "0x698C")]
			set
			{
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D2")]
		[Address(RVA = "0x698D", Offset = "0x698D", VA = "0x698D")]
		private void HandleNickVariantsChanged()
		{
		/* --- GHIDRA: HandleNickVariantsChanged ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__HandleNickVariantsChanged
		               (undefined4 param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a598d8 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a598d8 = '\x01';
		  }
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(iVar1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		            (*(undefined4 *)(iVar1 + 0x20),param2,*(undefined4 *)(iVar1 + 0x14));
		  System_ComponentModel_BindingList___Il2CppFullySharedGenericType___OnAddingNew(param1,2,0);
		  return;
		}
		*/

		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D3")]
		[Address(RVA = "0x698E", Offset = "0x698E", VA = "0x698E")]
		private void HandleConfirmButtonOnClickEvent(string nick)
		{
		/* --- GHIDRA: HandleConfirmButtonOnClickEvent ---
		undefined4
		Gameplay_UserInfo_View_ExistNickResolverWindow__HandleConfirmButtonOnClickEvent
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  int param1_00;
		  
		  if (DAT_ram_00a598d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_UserInfo_View_ExistNickResolverWindow_ExistNickResolveWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_ExistNickResolverWindow___)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12680);
		    DAT_ram_00a598d9 = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  param1_00 = unnamed_function_1417
		                        (
		                        Gameplay_UserInfo_View_ExistNickResolverWindow_ExistNickResolveWindowArgs_TypeInfo
		                        );
		  Gameplay_UserInfo_View_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor
		            (param1_00,param1_00);
		  *(undefined4 *)(param1_00 + 0x34) = param3;
		  *(undefined4 *)(param1_00 + 0x2c) = param1;
		  *(undefined4 *)(param1_00 + 0x30) = param2;
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12680,param1_00,
		                     Method_UI_Windows_PopupController_Show_ExistNickResolverWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017D4")]
		[Address(RVA = "0x698F", Offset = "0x698F", VA = "0x698F")]
		public static ExistNickResolverWindow Show(string sourceNick, RepeatedField<string> NickVariants, Action<string> resultCallback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__Show(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NickVariantItemRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_NickVariantItemRow__TypeInfo);
		    DAT_ram_00a598db = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_NickVariantItemRow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_NickVariantItemRow___ctor__);
		  *(undefined4 *)(param1 + 0x58) = param1_00;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor__
		            );
		  return;
		}
		*/

		/* --- GHIDRA: Show ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__Show(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a598db == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_NickVariantItemRow___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_NickVariantItemRow__TypeInfo);
		    DAT_ram_00a598db = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_NickVariantItemRow__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_NickVariantItemRow___ctor__);
		  *(undefined4 *)(param1 + 0x58) = param1_00;
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60017D5")]
		[Address(RVA = "0x6990", Offset = "0x6990", VA = "0x6990")]
		public static ExistNickResolverWindow Show(string sourceNick, RepeatedField<string> NickVariants, Action<string> resultCallback, RegisterCmd.Types.Result result)
		{
			return null;
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60017D6")]
		[Address(RVA = "0x6991", Offset = "0x6991", VA = "0x6991")]
		public ExistNickResolverWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow___ctor(int param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a598dc == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_15267);
		    DAT_ram_00a598dc = '\x01';
		  }
		  Gameplay_UserInfo_View_ExistNickResolverWindow_ExistNickResolveWindowArgs___ctor(param1,param1);
		  if (param2 == 1) {
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar1 = func_ii_7508(StringLiteral_15267,1,0,1,0,0,0,0);
		    *(undefined4 *)(param1 + 0x1c) = uVar1;
		  }
		  return;
		}
		*/

		}

		// Token: 0x04000CA1 RID: 3233
		[Token(Token = "0x4000CA1")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/UserInfo/ExistNickResolverWindow";

		// Token: 0x04000CA2 RID: 3234
		[Token(Token = "0x4000CA2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private NickVariantItemRow _itemRowPrefab;

		// Token: 0x04000CA3 RID: 3235
		[Token(Token = "0x4000CA3")]
		[FieldOffset(Offset = "0x54")]
		private RepeatedField<string> _nickVariants;

		// Token: 0x04000CA4 RID: 3236
		[Token(Token = "0x4000CA4")]
		[FieldOffset(Offset = "0x58")]
		private List<NickVariantItemRow> _rows;

		// Token: 0x020003F7 RID: 1015
		[Token(Token = "0x20003F7")]
		public class ExistNickResolveWindowArgs : BaseDialogWindow<ExistNickResolverWindow.ExistNickResolveWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060017D7 RID: 6103 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D7")]
			[Address(RVA = "0x6992", Offset = "0x6992", VA = "0x6992")]
			public ExistNickResolveWindowArgs(RegisterCmd.Types.Result registerResult)
			{
			}

			// Token: 0x060017D8 RID: 6104 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D8")]
			[Address(RVA = "0x6993", Offset = "0x6993", VA = "0x6993")]
			public ExistNickResolveWindowArgs()
			{
			}

			// Token: 0x060017D9 RID: 6105 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60017D9")]
			[Address(RVA = "0x6994", Offset = "0x6994", VA = "0x6994", Slot = "5")]
			public override void Dispose()
			{
			}

			// Token: 0x04000CA5 RID: 3237
			[Token(Token = "0x4000CA5")]
			[FieldOffset(Offset = "0x2C")]
			public string SourceNick;

			// Token: 0x04000CA6 RID: 3238
			[Token(Token = "0x4000CA6")]
			[FieldOffset(Offset = "0x30")]
			public RepeatedField<string> NickVariants;

			// Token: 0x04000CA7 RID: 3239
			[Token(Token = "0x4000CA7")]
			[FieldOffset(Offset = "0x34")]
			public Action<string> ResultCallback;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a598d4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		              );
		    DAT_ram_00a598d4 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar1 + 0x30) != *(int *)(param1 + 0x54)) {
		    *(int *)(param1 + 0x54) = *(int *)(iVar1 + 0x30);
		    Gameplay_UserInfo_View_ExistNickResolverWindow__set_NickVariants(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: get_NickVariants ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__get_NickVariants
		               (int param1,int param2,undefined4 param3)
		
		{
		  if (param2 != *(int *)(param1 + 0x54)) {
		    *(int *)(param1 + 0x54) = param2;
		    Gameplay_UserInfo_View_ExistNickResolverWindow__set_NickVariants(param1,param1);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_NickVariants ---
		void Gameplay_UserInfo_View_ExistNickResolverWindow__set_NickVariants(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  int iVar2;
		  int param1_00;
		  int iVar3;
		  int iVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *piVar7;
		  uint uVar8;
		  int param2_00;
		  int iVar9;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a598d7 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ExistNickResolverWindow_ExistNickResolveWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_UserInfo_View_ExistNickResolverWindow_HandleConfirmButtonOnClickEvent__
		              );
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_NickVariantItemRow__Add__);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_NickVariantItemRow___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		    DAT_ram_00a598d7 = '\x01';
		  }
		  iVar4 = *(int *)(*(int *)(param1 + 0x54) + 0xc);
		  if (0 < iVar4) {
		    do {
		      uVar5 = *(undefined4 *)(param1 + 0x40);
		      uVar6 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = func_ii_6805(uVar6,uVar5,
		                               Method_UnityEngine_Object_Instantiate_NickVariantItemRow___);
		      uVar5 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (param1_00,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar5,1,0);
		      piVar7 = *(int **)(param1_00 + 0x14);
		      uVar5 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x54),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_string__get_Item__);
		      iVar9 = *piVar7;
		      (**(code **)((ulonglong)*(uint *)(iVar9 + 0x2d0) * 4))
		                (piVar7,uVar5,*(undefined4 *)(iVar9 + 0x2d4));
		      uVar5 = unnamed_function_1417(System_Action_string__TypeInfo);
		      UnityEngine_UIElements_VisualElement__get_layout
		                (uVar5,param1,
		                 Method_Gameplay_UserInfo_View_ExistNickResolverWindow_HandleConfirmButtonOnClickEvent__
		                 ,0);
		      if (DAT_ram_00a598e0 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_string__TypeInfo);
		        DAT_ram_00a598e0 = '\x01';
		      }
		      iVar9 = *(int *)(param1_00 + 0x18);
		      do {
		        iVar2 = 0;
		        iVar3 = UnityEngine_UI_Image__set_sprite(iVar9,uVar5,0);
		        uVar6 = System_Action_string__TypeInfo;
		        if ((iVar3 != 0) && (iVar2 = func_ii_1082(iVar3,System_Action_string__TypeInfo), iVar2 == 0)
		           ) {
		          System_Activator__CreateInstance(iVar3,uVar6);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar3 = func_ii_4329(param1_00 + 0x18,iVar2,iVar9);
		        iVar2 = Method_System_Collections_Generic_List_NickVariantItemRow__Add__;
		        bVar1 = iVar3 != iVar9;
		        iVar9 = iVar3;
		      } while (bVar1);
		      iVar9 = *(int *)(param1 + 0x58);
		      *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		      uVar8 = *(uint *)(iVar9 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(iVar9 + 8) + 0xc)) {
		        *(uint *)(iVar9 + 0xc) = uVar8 + 1;
		        *(int *)(*(int *)(iVar9 + 8) + uVar8 * 4 + 0x10) = param1_00;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar9,param1_00,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		      }
		      param2_00 = param2_00 + 1;
		    } while (param2_00 != iVar4);
		  }
		  return;
		}
		*/

}

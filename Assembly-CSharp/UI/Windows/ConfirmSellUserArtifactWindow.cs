using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200028E RID: 654
	[Token(Token = "0x200028E")]
	public class ConfirmSellUserArtifactWindow : BaseDialogWindow<ConfirmSellUserArtifactWindow.SellUserArtifactWindowArgs>
	{
		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000F62 RID: 3938 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000221")]
		public override string WindowId
		{
			[Token(Token = "0x6000F62")]
			[Address(RVA = "0x618D", Offset = "0x618D", VA = "0x618D", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F63")]
		[Address(RVA = "0x618E", Offset = "0x618E", VA = "0x618E", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		UI_Windows_ConfirmSellUserArtifactWindow__HandleContent
		          (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param2_00;
		  int iVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  uint uVar6;
		  
		  if (DAT_ram_00a63a07 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__ArtifactData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__ArtifactData_____ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__ArtifactData____TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__set_Callback__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___Add__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_ConfirmSellUserArtifactWindow___);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0__Show_b__0__);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0__Show_b__1__);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8384);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12636);
		    Mono_Security_ASN1__get_Item(&StringLiteral_13766);
		    Mono_Security_ASN1__get_Item(&StringLiteral_7824);
		    DAT_ram_00a63a07 = '\x01';
		  }
		  param2_00 = unnamed_function_1417
		                        (UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  iVar1 = unnamed_function_1417
		                    (UI_Windows_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs_TypeInfo);
		  if (DAT_ram_00a63a09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a63a09 = '\x01';
		  }
		  *(undefined4 *)(iVar1 + 0x34) = 6;
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		            );
		  *(undefined4 *)(iVar1 + 0x30) = param1;
		  *(undefined4 *)(iVar1 + 0x2c) = param3;
		  UI_Windows_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor(iVar1,iVar1);
		  *(int *)(param2_00 + 8) = iVar1;
		  if (*(char *)(iVar1 + 0x3d) != '\0') {
		    iVar2 = *(int *)(iVar1 + 0x24);
		    iVar1 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		                      );
		    UI_Windows_DialogWindow_DialogWindowArgs___ctor
		              (iVar1,
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar5 = func_ii_7508(StringLiteral_7824,1,0,1,0,0,0,0);
		    *(undefined4 *)(iVar1 + 8) = uVar5;
		    iVar3 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		                      );
		    uVar5 = unnamed_function_1417
		                      (
		                      UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		                      );
		    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_object____ctor
		              (uVar5,param2_00,
		               Method_UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0__Show_b__0__,0);
		    *(undefined4 *)(iVar3 + 8) = uVar5;
		    *(int *)(iVar1 + 0x14) = iVar3;
		    iVar3 = 
		    Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___Add__
		    ;
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar6 = *(uint *)(iVar2 + 0xc);
		    if (uVar6 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar6 + 1;
		      *(int *)(*(int *)(iVar2 + 8) + uVar6 * 4 + 0x10) = iVar1;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (iVar2,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    }
		  }
		  iVar3 = *(int *)(*(int *)(param2_00 + 8) + 0x24);
		  iVar1 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__TypeInfo
		                    );
		  UI_Windows_DialogWindow_DialogWindowArgs___ctor
		            (iVar1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		            );
		  puVar4 = &StringLiteral_8384;
		  iVar2 = Core_Extensions_Dict_ResourceSetExt__GetDelta
		                    (*(undefined4 *)(*(int *)(param2_00 + 8) + 0x40),0);
		  if (iVar2 == 0) {
		    puVar4 = &StringLiteral_13766;
		  }
		  uVar5 = *puVar4;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar5 = func_ii_7508(uVar5,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar1 + 8) = uVar5;
		  iVar2 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__ArtifactData____TypeInfo
		                    );
		  *(undefined4 *)(iVar2 + 0xc) = param3;
		  uVar5 = unnamed_function_1417
		                    (
		                    UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__ArtifactData____TypeInfo
		                    );
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ButtonInvoker_ButtonCallbackDelegate_object__Int32Enum___Invoke
		            (uVar5,param2_00,
		             Method_UI_Windows_ConfirmSellUserArtifactWindow___c__DisplayClass6_0__Show_b__1__,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar5;
		  *(int *)(iVar1 + 0x14) = iVar2;
		  iVar2 = 
		  Method_System_Collections_Generic_List_BaseDialogWindow_BaseDialogWindowArgs_DialogWindowButton_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___Add__
		  ;
		  *(int *)(iVar3 + 0x10) = *(int *)(iVar3 + 0x10) + 1;
		  uVar6 = *(uint *)(iVar3 + 0xc);
		  if (uVar6 < *(uint *)(*(int *)(iVar3 + 8) + 0xc)) {
		    *(uint *)(iVar3 + 0xc) = uVar6 + 1;
		    *(int *)(*(int *)(iVar3 + 8) + uVar6 * 4 + 0x10) = iVar1;
		  }
		  else {
		    System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		              (iVar3,iVar1,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		  }
		  uVar5 = System_Uri___ctor(0);
		  uVar5 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar5,0);
		  uVar5 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar5,StringLiteral_12636,*(undefined4 *)(param2_00 + 8),
		                     Method_UI_Windows_PopupController_Show_ConfirmSellUserArtifactWindow___);
		  return uVar5;
		}
		*/

		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000F64")]
		[Address(RVA = "0x618F", Offset = "0x618F", VA = "0x618F")]
		public static ConfirmSellUserArtifactWindow Show(UserData user, Action<ArtifactData[]> resultCallback, params ArtifactData[] artifacts)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_ConfirmSellUserArtifactWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a63a08 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a63a08 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F65")]
		[Address(RVA = "0x6190", Offset = "0x6190", VA = "0x6190")]
		public ConfirmSellUserArtifactWindow()
		{
		/* --- GHIDRA: .ctor ---
		void UI_Windows_ConfirmSellUserArtifactWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a63a09 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a63a09 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x34) = 6;
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = param3;
		  *(undefined4 *)(param1 + 0x2c) = param2;
		  UI_Windows_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs___ctor(param1,param1);
		  return;
		}
		*/

		}

		// Token: 0x040007D3 RID: 2003
		[Token(Token = "0x40007D3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/ConfirmSellUserArtifactWindow";

		// Token: 0x040007D4 RID: 2004
		[Token(Token = "0x40007D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x0200028F RID: 655
		[Token(Token = "0x200028F")]
		public class SellUserArtifactWindowArgs : BaseDialogWindow<ConfirmSellUserArtifactWindow.SellUserArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x06000F66 RID: 3942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F66")]
			[Address(RVA = "0x6191", Offset = "0x6191", VA = "0x6191")]
			public SellUserArtifactWindowArgs(ArtifactData[] artifacts, UserData user)
			{
			}

			// Token: 0x06000F67 RID: 3943 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F67")]
			[Address(RVA = "0x6192", Offset = "0x6192", VA = "0x6192")]
			private void InitInstance()
			{
			}

			// Token: 0x06000F68 RID: 3944 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F68")]
			[Address(RVA = "0x6193", Offset = "0x6193", VA = "0x6193", Slot = "6")]
			protected virtual void DefineTitle()
			{
			}

			// Token: 0x06000F69 RID: 3945 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F69")]
			[Address(RVA = "0x6194", Offset = "0x6194", VA = "0x6194", Slot = "7")]
			protected virtual void DetermineNonZeroDescription()
			{
			}

			// Token: 0x17000222 RID: 546
			// (get) Token: 0x06000F6A RID: 3946 RVA: 0x000044A0 File Offset: 0x000026A0
			// (set) Token: 0x06000F6B RID: 3947 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000222")]
			public int MaxArtifactCountForDisplay
			{
				[Token(Token = "0x6000F6A")]
				[Address(RVA = "0x6195", Offset = "0x6195", VA = "0x6195")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6000F6B")]
				[Address(RVA = "0x6196", Offset = "0x6196", VA = "0x6196")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000223 RID: 547
			// (get) Token: 0x06000F6C RID: 3948 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F6D RID: 3949 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000223")]
			public uint[] SlotIds
			{
				[Token(Token = "0x6000F6C")]
				[Address(RVA = "0x6197", Offset = "0x6197", VA = "0x6197")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F6D")]
				[Address(RVA = "0x6198", Offset = "0x6198", VA = "0x6198")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000224 RID: 548
			// (get) Token: 0x06000F6E RID: 3950 RVA: 0x000044B8 File Offset: 0x000026B8
			// (set) Token: 0x06000F6F RID: 3951 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000224")]
			public bool IsContainsStackable
			{
				[Token(Token = "0x6000F6E")]
				[Address(RVA = "0x6199", Offset = "0x6199", VA = "0x6199")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000F6F")]
				[Address(RVA = "0x619A", Offset = "0x619A", VA = "0x619A")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000225 RID: 549
			// (get) Token: 0x06000F70 RID: 3952 RVA: 0x000044D0 File Offset: 0x000026D0
			// (set) Token: 0x06000F71 RID: 3953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000225")]
			public bool IsContainsBroken
			{
				[Token(Token = "0x6000F70")]
				[Address(RVA = "0x619B", Offset = "0x619B", VA = "0x619B")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000F71")]
				[Address(RVA = "0x619C", Offset = "0x619C", VA = "0x619C")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000226 RID: 550
			// (get) Token: 0x06000F72 RID: 3954 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F73 RID: 3955 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000226")]
			public ResourceSet Price
			{
				[Token(Token = "0x6000F72")]
				[Address(RVA = "0x619D", Offset = "0x619D", VA = "0x619D")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F73")]
				[Address(RVA = "0x619E", Offset = "0x619E", VA = "0x619E")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000227 RID: 551
			// (get) Token: 0x06000F74 RID: 3956 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000F75 RID: 3957 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000227")]
			public ResourceSet TradePrice
			{
				[Token(Token = "0x6000F74")]
				[Address(RVA = "0x619F", Offset = "0x619F", VA = "0x619F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000F75")]
				[Address(RVA = "0x61A0", Offset = "0x61A0", VA = "0x61A0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_ConfirmSellUserArtifactWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  int iVar3;
		  undefined4 uVar4;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  undefined8 local_18;
		  undefined4 local_10;
		  int local_c;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a63a06 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a63a06 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		                      );
		  iVar3 = *(int *)(iVar1 + 0x2c);
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		                      );
		  if (*(int *)(iVar3 + 0xc) <= *(int *)(iVar1 + 0x34)) {
		    iVar1 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		                        );
		    iVar1 = *(int *)(iVar1 + 0x2c);
		    iVar3 = func_ii_8093(param1,
		                         Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		                        );
		    iVar1 = *(int *)(iVar1 + 0xc);
		    if (*(int *)(iVar3 + 0x34) <= iVar1) {
		      iVar1 = *(int *)(iVar3 + 0x34);
		    }
		    if (0 < iVar1) {
		      iVar3 = 0;
		      do {
		        iVar2 = func_ii_8093(param1,
		                             Method_UI_Windows_BaseWindow_ConfirmSellUserArtifactWindow_SellUserArtifactWindowArgs__get_WindowArgs__
		                            );
		        uVar4 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + iVar3 * 4 + 0x10);
		        param2_00 = *(undefined4 *)(param1 + 0x40);
		        param1_01 = *(undefined4 *)(param1 + 0x50);
		        if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		          func_ii_306000(UnityEngine_Object_TypeInfo);
		        }
		        param1_00 = (int *)func_ii_6805(param1_01,param2_00,
		                                        Method_UnityEngine_Object_Instantiate_ArtifactView___);
		        (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                  (param1_00,uVar4,*(undefined4 *)(*param1_00 + 0x13c));
		        iVar2 = param1_00[0x14];
		        local_8 = Mono_Security_ASN1Convert__ToOid
		                            (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		        *(undefined4 *)(local_8 + 0x10) = 5;
		        local_4 = 0;
		        local_10 = 0;
		        local_18 = CONCAT44(local_8,iVar2);
		        local_c = iVar2;
		        func_ii_7564(param1_00,&local_18,0);
		        iVar3 = iVar3 + 1;
		      } while (iVar3 != iVar1);
		    }
		  }
		  return;
		}
		*/

}

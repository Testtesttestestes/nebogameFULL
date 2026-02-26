using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Data.Balance;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using UI.Requirements;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200029B RID: 667
	[Token(Token = "0x200029B")]
	public class RequirementsWindow : BaseDialogWindow<RequirementsWindow.RequirementsWindowArgs>
	{
		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000FA4 RID: 4004 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000231")]
		public override string WindowId
		{
			[Token(Token = "0x6000FA4")]
			[Address(RVA = "0x61CD", Offset = "0x61CD", VA = "0x61CD", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA5")]
		[Address(RVA = "0x61CE", Offset = "0x61CE", VA = "0x61CE", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4 UI_Windows_RequirementsWindow__HandleContent(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a6e == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RequirementsWindow___);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12662);
		    DAT_ram_00a58a6e = '\x01';
		  }
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12662,param1,
		                     Method_UI_Windows_PopupController_Show_RequirementsWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0x61CF", Offset = "0x61CF", VA = "0x61CF")]
		public static RequirementsWindow Show(RequirementsWindow.RequirementsWindowArgs args)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_RequirementsWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a6f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RequirementsWindow_RequirementsWindowArgs___ctor__
		              );
		    DAT_ram_00a58a6f = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_RequirementsWindow_RequirementsWindowArgs___ctor__);
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FA7")]
		[Address(RVA = "0x61D0", Offset = "0x61D0", VA = "0x61D0")]
		public RequirementsWindow()
		{
		}

		// Token: 0x040007F2 RID: 2034
		[Token(Token = "0x40007F2")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RequirementsView _viewPrefab;

		// Token: 0x040007F3 RID: 2035
		[Token(Token = "0x40007F3")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/RequirementsWindow";

		// Token: 0x0200029C RID: 668
		[Token(Token = "0x200029C")]
		public class RequirementsWindowArgs : BaseDialogWindow<RequirementsWindow.RequirementsWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000232 RID: 562
			// (get) Token: 0x06000FA8 RID: 4008 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FA9 RID: 4009 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000232")]
			public IBalanceSource BalanceSource
			{
				[Token(Token = "0x6000FA8")]
				[Address(RVA = "0x61D1", Offset = "0x61D1", VA = "0x61D1")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FA9")]
				[Address(RVA = "0x61D2", Offset = "0x61D2", VA = "0x61D2")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000233 RID: 563
			// (get) Token: 0x06000FAA RID: 4010 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FAB RID: 4011 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000233")]
			public UserData User
			{
				[Token(Token = "0x6000FAA")]
				[Address(RVA = "0x61D3", Offset = "0x61D3", VA = "0x61D3")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FAB")]
				[Address(RVA = "0x61D4", Offset = "0x61D4", VA = "0x61D4")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000FAC RID: 4012 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FAC")]
			[Address(RVA = "0x61D5", Offset = "0x61D5", VA = "0x61D5")]
			public RequirementsWindowArgs(IBalanceSource balanceSource, UserData user, RequirementDic requirements)
			{
			}

			// Token: 0x06000FAD RID: 4013 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FAD")]
			[Address(RVA = "0x61D6", Offset = "0x61D6", VA = "0x61D6")]
			public RequirementsWindowArgs(IBalanceSource balanceSource, UserData user, ResourceSet cost, IList<RestrictionInfo> restrictionInfos, IList<RewardInfo> materials)
			{
			}

			// Token: 0x040007F6 RID: 2038
			[Token(Token = "0x40007F6")]
			[FieldOffset(Offset = "0x34")]
			public ResourceSet Cost;

			// Token: 0x040007F7 RID: 2039
			[Token(Token = "0x40007F7")]
			[FieldOffset(Offset = "0x38")]
			public IList<RestrictionInfo> Restrictions;

			// Token: 0x040007F8 RID: 2040
			[Token(Token = "0x40007F8")]
			[FieldOffset(Offset = "0x3C")]
			public IList<RewardInfo> Materials;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_RequirementsWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  undefined4 param1_00;
		  undefined4 param2_00;
		  int *piVar6;
		  undefined4 uVar7;
		  undefined4 uVar8;
		  
		  if (DAT_ram_00a58a6d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RequirementsWindow_RequirementsWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		    DAT_ram_00a58a6d = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_RequirementsWindow_RequirementsWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		                      );
		  param2_00 = *(undefined4 *)(iVar2 + 0x30);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80f69e16;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f69e16:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar4 = func_ii_7112(uVar4,0);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		                      );
		  uVar7 = *(undefined4 *)(iVar2 + 0x2c);
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar6 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar2 = *piVar6;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x140);
		        goto code_r0x80f69edb;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(piVar6,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80f69edb:
		  uVar5 = (**(code **)((ulonglong)*puVar3 * 4))(piVar6,puVar3[1]);
		  uVar5 = func_ii_7112(uVar5,0);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		                      );
		  uVar8 = *(undefined4 *)(iVar2 + 0x34);
		  param1_00 = unnamed_function_1417
		                        (Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_CostRequirementsInfoProvider__Dispose
		            (param1_00,uVar7,uVar5,uVar8,0);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		                      );
		  uVar5 = *(undefined4 *)(iVar2 + 0x38);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RequirementsWindow_RequirementsWindowArgs__get_WindowArgs__
		                      );
		  uVar8 = *(undefined4 *)(iVar2 + 0x3c);
		  uVar7 = unnamed_function_1417
		                    (Core_Gameplay_Managers_Requirements_RequirementsInfoProvider_TypeInfo);
		  Core_Gameplay_Managers_Requirements_RequirementsInfoProvider__Dispose
		            (uVar7,param2_00,uVar4,param1_00,uVar5,uVar8,0);
		  UI_Requirements_RequirementsView__get_Data(*(undefined4 *)(param1 + 0x50),uVar7,0);
		  return;
		}
		*/

}

using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Core.Gameplay;
using Gameplay.Bank.Model;
using Gameplay.Billing.Model;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Bank.View
{
	// Token: 0x02000C4D RID: 3149
	[Token(Token = "0x2000C4D")]
	public class SelectBillingDialogWindow : BaseDialogWindow<SelectBillingDialogWindow.SelectBillingDialogWindowArgs>
	{
		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004CC6 RID: 19654 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000F7B")]
		public override string WindowId
		{
			[Token(Token = "0x6004CC6")]
			[Address(RVA = "0x9B03", Offset = "0x9B03", VA = "0x9B03", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC7")]
		[Address(RVA = "0x9B04", Offset = "0x9B04", VA = "0x9B04", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4
		Gameplay_Bank_View_SelectBillingDialogWindow__HandleContent
		          (int *param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5)
		
		{
		  uint uVar1;
		  undefined4 uVar2;
		  uint *puVar3;
		  int *param1_00;
		  undefined4 param1_01;
		  int iVar4;
		  
		  if (DAT_ram_00a597ae == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_PopupController_Show_SelectBillingDialogWindow___);
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_TypeInfo)
		    ;
		    Mono_Security_ASN1__get_Item(&StringLiteral_12573);
		    DAT_ram_00a597ae = '\x01';
		  }
		  uVar2 = unnamed_function_1417
		                    (
		                    Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs_TypeInfo
		                    );
		  Gameplay_Bank_View_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_Callback
		            (uVar2,param1,param2,param3,param4,param4);
		  iVar4 = *param1;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x8106a1d0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x8106a1d0:
		  param1_00 = (int *)(**(code **)((ulonglong)*puVar3 * 4))(param1,puVar3[1]);
		  uVar1 = 0;
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe8);
		        goto code_r0x8106a24e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Application_IApp_TypeInfo,5);
		code_r0x8106a24e:
		  param1_01 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  uVar2 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (param1_01,StringLiteral_12573,uVar2,
		                     Method_UI_Windows_PopupController_Show_SelectBillingDialogWindow___);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6004CC8")]
		[Address(RVA = "0x9B05", Offset = "0x9B05", VA = "0x9B05")]
		public static SelectBillingDialogWindow Show(IGame game, BankOptionData option, SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] items, Action<BillingProviderId, BankOptionData> callback)
		{
		/* --- GHIDRA: Show ---
		void Gameplay_Bank_View_SelectBillingDialogWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a597af == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a597af = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004CC9")]
		[Address(RVA = "0x9B06", Offset = "0x9B06", VA = "0x9B06")]
		public SelectBillingDialogWindow()
		{
		}

		// Token: 0x040029E9 RID: 10729
		[Token(Token = "0x40029E9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Bank/SelectBillingDialogWindow";

		// Token: 0x040029EA RID: 10730
		[Token(Token = "0x40029EA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _billingImages;

		// Token: 0x040029EB RID: 10731
		[Token(Token = "0x40029EB")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private GameAssetViewRawImage _imagePrefab;

		// Token: 0x02000C4E RID: 3150
		[Token(Token = "0x2000C4E")]
		public class SelectBillingDialogWindowArgs : BaseDialogWindow<SelectBillingDialogWindow.SelectBillingDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000F7C RID: 3964
			// (get) Token: 0x06004CCA RID: 19658 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7C")]
			public IGame Game
			{
				[Token(Token = "0x6004CCA")]
				[Address(RVA = "0x9B07", Offset = "0x9B07", VA = "0x9B07")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7D RID: 3965
			// (get) Token: 0x06004CCB RID: 19659 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7D")]
			public BankOptionData Option
			{
				[Token(Token = "0x6004CCB")]
				[Address(RVA = "0x9B08", Offset = "0x9B08", VA = "0x9B08")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7E RID: 3966
			// (get) Token: 0x06004CCC RID: 19660 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7E")]
			public SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] Configs
			{
				[Token(Token = "0x6004CCC")]
				[Address(RVA = "0x9B09", Offset = "0x9B09", VA = "0x9B09")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x17000F7F RID: 3967
			// (get) Token: 0x06004CCD RID: 19661 RVA: 0x00002052 File Offset: 0x00000252
			[Token(Token = "0x17000F7F")]
			public Action<BillingProviderId, BankOptionData> Callback
			{
				[Token(Token = "0x6004CCD")]
				[Address(RVA = "0x9B0A", Offset = "0x9B0A", VA = "0x9B0A")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x06004CCE RID: 19662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6004CCE")]
			[Address(RVA = "0x9B0B", Offset = "0x9B0B", VA = "0x9B0B")]
			public SelectBillingDialogWindowArgs(IGame game, BankOptionData option, SelectBillingDialogWindow.SelectBillingDialogWindowArgs.Config[] configs, Action<BillingProviderId, BankOptionData> callback)
			{
			}

			// Token: 0x02000C4F RID: 3151
			[Token(Token = "0x2000C4F")]
			public class Config
			{
				// Token: 0x06004CCF RID: 19663 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6004CCF")]
				[Address(RVA = "0x9B0C", Offset = "0x9B0C", VA = "0x9B0C")]
				public Config(BillingProviderId id, string buttonLabelLocaleKey, string uiResourceKey)
				{
				}

				// Token: 0x040029F0 RID: 10736
				[Token(Token = "0x40029F0")]
				[FieldOffset(Offset = "0x8")]
				public readonly BillingProviderId Id;

				// Token: 0x040029F1 RID: 10737
				[Token(Token = "0x40029F1")]
				[FieldOffset(Offset = "0xC")]
				public readonly string ButtonLabelLocaleKey;

				// Token: 0x040029F2 RID: 10738
				[Token(Token = "0x40029F2")]
				[FieldOffset(Offset = "0x10")]
				public readonly string UIResourceKey;
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Bank_View_SelectBillingDialogWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  int *param1_00;
		  int iVar7;
		  int *piVar8;
		  
		  iVar7 = 0;
		  if (DAT_ram_00a597ad == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_GameAssetViewRawImage___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a597ad = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__HandleContent__
		            );
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_WindowArgs__
		                      );
		  if (0 < *(int *)(*(int *)(iVar2 + 0x34) + 0xc)) {
		    do {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_WindowArgs__
		                          );
		      iVar2 = *(int *)(*(int *)(iVar2 + 0x34) + iVar7 * 4 + 0x10);
		      uVar5 = *(undefined4 *)(param1 + 0x50);
		      uVar6 = *(undefined4 *)(param1 + 0x54);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      uVar5 = func_ii_6805(uVar6,uVar5,
		                           Method_UnityEngine_Object_Instantiate_GameAssetViewRawImage___);
		      uVar6 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (uVar5,0);
		      Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		                (uVar6,1,0);
		      iVar3 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_WindowArgs__
		                          );
		      param1_00 = *(int **)(iVar3 + 0x2c);
		      iVar3 = *param1_00;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar8 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (Core_Gameplay_IGame_TypeInfo == *piVar8) {
		            puVar4 = (uint *)(piVar8[1] * 8 + iVar3 + 0x178);
		            goto code_r0x8106a0b8;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8106a0b8:
		      uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		      uVar6 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar6,0);
		      uVar6 = Core_Extensions_Dict_DictExt__GetServiceOptionDic
		                        (uVar6,*(undefined4 *)(iVar2 + 0x10),0);
		      Core_Extensions_Dict_AprDicExt__Get1024AssetId(uVar5,uVar6,0);
		      iVar7 = iVar7 + 1;
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_SelectBillingDialogWindow_SelectBillingDialogWindowArgs__get_WindowArgs__
		                          );
		    } while (iVar7 < *(int *)(*(int *)(iVar2 + 0x34) + 0xc));
		  }
		  return;
		}
		*/

}

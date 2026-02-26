using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.Windows
{
	// Token: 0x0200029D RID: 669
	[Token(Token = "0x200029D")]
	public class RestoreArtifactWindow : BaseDialogWindow<RestoreArtifactWindow.RestoreArtifactWindowArgs>
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000FAE RID: 4014 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000234")]
		public override string WindowId
		{
			[Token(Token = "0x6000FAE")]
			[Address(RVA = "0x61D7", Offset = "0x61D7", VA = "0x61D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FAF")]
		[Address(RVA = "0x61D8", Offset = "0x61D8", VA = "0x61D8", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		undefined4 UI_Windows_RestoreArtifactWindow__HandleContent(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58a73 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_Windows_PopupController_Show_RestoreArtifactWindow___);
		    Mono_Security_ASN1__get_Item
		              (&UI_Windows_RestoreArtifactWindow_RestoreArtifactWindowArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_12642);
		    DAT_ram_00a58a73 = '\x01';
		  }
		  param1_00 = (int *)unnamed_function_1417
		                               (UI_Windows_RestoreArtifactWindow_RestoreArtifactWindowArgs_TypeInfo)
		  ;
		  if (DAT_ram_00a58a75 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RestoreArtifactWindow_RestoreArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a58a75 = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1_00,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_RestoreArtifactWindow_RestoreArtifactWindowArgs___ctor__
		            );
		  param1_00[0xb] = param1;
		  (**(code **)((ulonglong)*(uint *)(*param1_00 + 0xf0) * 4))
		            (param1_00,*(undefined4 *)(*param1_00 + 0xf4));
		  uVar1 = System_Uri___ctor(0);
		  uVar1 = System_Globalization_TimeSpanFormat_FormatLiterals__get_Start(uVar1,0);
		  uVar1 = Gameplay_Antiq_View_GroupReviewWindow_WindowArgs___ctor
		                    (uVar1,StringLiteral_12642,param1_00,
		                     Method_UI_Windows_PopupController_Show_RestoreArtifactWindow___);
		  return uVar1;
		}
		*/

		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000FB0")]
		[Address(RVA = "0x61D9", Offset = "0x61D9", VA = "0x61D9")]
		public static RestoreArtifactWindow Show(ArtifactData artifactData)
		{
		/* --- GHIDRA: Show ---
		void UI_Windows_RestoreArtifactWindow__Show(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a74 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs___ctor__
		              );
		    DAT_ram_00a58a74 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs___ctor__
		            );
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB1")]
		[Address(RVA = "0x61DA", Offset = "0x61DA", VA = "0x61DA")]
		public RestoreArtifactWindow()
		{
		}

		// Token: 0x040007F9 RID: 2041
		[Token(Token = "0x40007F9")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/RestoreArtifactWindow";

		// Token: 0x040007FA RID: 2042
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x0200029E RID: 670
		[Token(Token = "0x200029E")]
		public class RestoreArtifactWindowArgs : BaseDialogWindow<RestoreArtifactWindow.RestoreArtifactWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x17000235 RID: 565
			// (get) Token: 0x06000FB2 RID: 4018 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x06000FB3 RID: 4019 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000235")]
			public ArtifactData Artifact
			{
				[Token(Token = "0x6000FB2")]
				[Address(RVA = "0x61DB", Offset = "0x61DB", VA = "0x61DB")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6000FB3")]
				[Address(RVA = "0x61DC", Offset = "0x61DC", VA = "0x61DC")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06000FB4 RID: 4020 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FB4")]
			[Address(RVA = "0x61DD", Offset = "0x61DD", VA = "0x61DD")]
			public RestoreArtifactWindowArgs(ArtifactData artifact)
			{
			}

			// Token: 0x06000FB5 RID: 4021 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x61DE", Offset = "0x61DE", VA = "0x61DE", Slot = "6")]
			protected virtual void InitInstance()
			{
			}
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void UI_Windows_RestoreArtifactWindow__get_WindowId(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58a72 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a58a72 = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs__HandleContent__
		            );
		  param2_00 = *(undefined4 *)(param1 + 0x40);
		  param1_00 = *(undefined4 *)(param1 + 0x50);
		  if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		    func_ii_306000(UnityEngine_Object_TypeInfo);
		  }
		  piVar1 = (int *)func_ii_6805(param1_00,param2_00,
		                               Method_UnityEngine_Object_Instantiate_ArtifactView___);
		  iVar2 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_RestoreArtifactWindow_RestoreArtifactWindowArgs__get_WindowArgs__
		                      );
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x138) * 4))
		            (piVar1,*(undefined4 *)(iVar2 + 0x2c),*(undefined4 *)(*piVar1 + 0x13c));
		  return;
		}
		*/

}

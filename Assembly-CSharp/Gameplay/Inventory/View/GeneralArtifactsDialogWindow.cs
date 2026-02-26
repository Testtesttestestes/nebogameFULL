using System;
using Core.Data;
using Il2CppDummyDll;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Inventory.View
{
	// Token: 0x02000660 RID: 1632
	[Token(Token = "0x2000660")]
	public class GeneralArtifactsDialogWindow : BaseDialogWindow<GeneralArtifactsDialogWindow.GeneralArtifactsDialogWindowArgs>
	{
		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000780")]
		public override string WindowId
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x78D7", Offset = "0x78D7", VA = "0x78D7", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x78D8", Offset = "0x78D8", VA = "0x78D8", Slot = "28")]
		protected override void HandleContent()
		{
		/* --- GHIDRA: HandleContent ---
		void Gameplay_Inventory_View_GeneralArtifactsDialogWindow__HandleContent
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a5a0ab == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0ab = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_object____ctor
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		            );
		  return;
		}
		*/

		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x78D9", Offset = "0x78D9", VA = "0x78D9")]
		public GeneralArtifactsDialogWindow()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_GeneralArtifactsDialogWindow___ctor
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  if (DAT_ram_00a5a0ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		              );
		    DAT_ram_00a5a0ac = '\x01';
		  }
		  UnityEngine_UIElements_BaseCompositeField___Il2CppFullySharedGenericType__object____Il2CppFullySharedGenericType___UpdateMixedValueContent
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_BaseDialogWindowArgs_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs___ctor__
		            );
		  *(undefined4 *)(param1 + 0x30) = param2;
		  *(undefined4 *)(param1 + 0x2c) = param3;
		  return;
		}
		*/

		}

		// Token: 0x040015B8 RID: 5560
		[Token(Token = "0x40015B8")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Inventory/GeneralArtifactsDialogWindow";

		// Token: 0x040015B9 RID: 5561
		[Token(Token = "0x40015B9")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ArtifactView _artifactViewPrefab;

		// Token: 0x02000661 RID: 1633
		[Token(Token = "0x2000661")]
		public class GeneralArtifactsDialogWindowArgs : BaseDialogWindow<GeneralArtifactsDialogWindow.GeneralArtifactsDialogWindowArgs>.BaseDialogWindowArgs
		{
			// Token: 0x060027AB RID: 10155 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60027AB")]
			[Address(RVA = "0x78DA", Offset = "0x78DA", VA = "0x78DA")]
			public GeneralArtifactsDialogWindowArgs(UserData user, params ArtifactData[] artifacts)
			{
			}

			// Token: 0x040015BA RID: 5562
			[Token(Token = "0x40015BA")]
			[FieldOffset(Offset = "0x2C")]
			public ArtifactData[] Artifacts;

			// Token: 0x040015BB RID: 5563
			[Token(Token = "0x40015BB")]
			[FieldOffset(Offset = "0x30")]
			public UserData User;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WindowId ---
		void Gameplay_Inventory_View_GeneralArtifactsDialogWindow__get_WindowId
		               (int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  int *param1_00;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  undefined4 param1_01;
		  int iVar4;
		  int iVar5;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a5a0aa == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__HandleContent__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseDialogWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__get_Content__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_UI_Windows_BaseWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__get_WindowArgs__
		              );
		    Mono_Security_ASN1__get_Item(&Method_UnityEngine_Object_Instantiate_ArtifactView___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Object_TypeInfo);
		    DAT_ram_00a5a0aa = '\x01';
		  }
		  UI_Windows_BaseDialogWindow_object___HandleButtons
		            (param1,
		             Method_UI_Windows_BaseDialogWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__HandleContent__
		            );
		  iVar1 = func_ii_8093(param1,
		                       Method_UI_Windows_BaseWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__get_WindowArgs__
		                      );
		  iVar1 = *(int *)(*(int *)(iVar1 + 0x2c) + 0xc);
		  if (0 < iVar1) {
		    do {
		      iVar2 = func_ii_8093(param1,
		                           Method_UI_Windows_BaseWindow_GeneralArtifactsDialogWindow_GeneralArtifactsDialogWindowArgs__get_WindowArgs__
		                          );
		      uVar3 = *(undefined4 *)(*(int *)(iVar2 + 0x2c) + iVar5 * 4 + 0x10);
		      param2_00 = *(undefined4 *)(param1 + 0x40);
		      param1_01 = *(undefined4 *)(param1 + 0x50);
		      if (*(int *)(UnityEngine_Object_TypeInfo + 0x74) == 0) {
		        func_ii_306000(UnityEngine_Object_TypeInfo);
		      }
		      param1_00 = (int *)func_ii_6805(param1_01,param2_00,
		                                      Method_UnityEngine_Object_Instantiate_ArtifactView___);
		      (**(code **)((ulonglong)*(uint *)(*param1_00 + 0x138) * 4))
		                (param1_00,uVar3,*(undefined4 *)(*param1_00 + 0x13c));
		      iVar4 = param1_00[0x14];
		      iVar2 = Mono_Security_ASN1Convert__ToOid
		                        (Protocol_Dic_ArtikulMenuActionDic_Types_Actions___TypeInfo,1);
		      *(undefined4 *)(iVar2 + 0x10) = 5;
		      param1_00[0x16] = 0;
		      param1_00[0x15] = iVar2;
		      param1_00[0x14] = iVar4;
		      *(undefined1 *)((int)param1_00 + 0x45) = 1;
		      UI_AbstractDeferredRenderer__KillCoroutine(param1_00,0);
		      iVar5 = iVar5 + 1;
		    } while (iVar5 != iVar1);
		  }
		  return;
		}
		*/

}

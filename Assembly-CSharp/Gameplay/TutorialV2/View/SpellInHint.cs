using System;
using AssetContent;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.TutorialV2.View
{
	// Token: 0x0200042A RID: 1066
	[Token(Token = "0x200042A")]
	public class SpellInHint : MonoBehaviour
	{
		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700046D")]
		public GameRawImage Icon
		{
			[Token(Token = "0x600193B")]
			[Address(RVA = "0x6ADA", Offset = "0x6ADA", VA = "0x6ADA")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600193C")]
		[Address(RVA = "0x6ADB", Offset = "0x6ADB", VA = "0x6ADB")]
		public SpellInHint()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_TutorialV2_View_SpellInHint___ctor(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *piVar3;
		  int iVar4;
		  undefined4 param1_01;
		  int iVar5;
		  
		  if (DAT_ram_00a583aa == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ToggleButton__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Data_User_IUserSettings_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_TutorialV2_View_TutorialAdditionalView_ToggleValueChangedEventHandler__
		              );
		    DAT_ram_00a583aa = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x220);
		        goto code_r0x80edba92;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x2c);
		code_r0x80edba92:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x18);
		  iVar4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                    (*(int **)(iVar4 + 0x18),*(undefined4 *)(iVar5 + 0x104));
		  uVar1 = 0;
		  piVar3 = *(int **)(iVar4 + 0xc);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Data_User_IUserSettings_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80edbb30;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Data_User_IUserSettings_TypeInfo,0);
		code_r0x80edbb30:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  UI_ToggleButton__get_Selected(*(undefined4 *)(param1 + 0x10),(uint)*(byte *)(iVar4 + 9),0);
		  param1_01 = *(undefined4 *)(param1 + 0x10);
		  param1_00 = unnamed_function_1417(System_Action_ToggleButton__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,
		             Method_Gameplay_TutorialV2_View_TutorialAdditionalView_ToggleValueChangedEventHandler__
		             ,0);
		  UI_TileAndScrollEntitieDescription___ctor(param1_01,param1_00,0);
		  return;
		}
		*/

		}

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameRawImage _icon;
	}
}

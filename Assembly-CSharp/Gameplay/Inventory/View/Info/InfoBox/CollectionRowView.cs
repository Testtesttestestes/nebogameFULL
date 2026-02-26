using System;
using System.Collections.Generic;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using UnityEngine;

namespace Gameplay.Inventory.View.Info.InfoBox
{
	// Token: 0x02000677 RID: 1655
	[Token(Token = "0x2000677")]
	public class CollectionRowView : TitleRowView
	{
		// Token: 0x06002823 RID: 10275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002823")]
		[Address(RVA = "0x7948", Offset = "0x7948", VA = "0x7948", Slot = "5")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_Inventory_View_Info_InfoBox_CollectionRowView__HandleDataChanged
		               (int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5a0d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameObject___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_GameObject__TypeInfo);
		    DAT_ram_00a5a0d8 = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_List_GameObject__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_GameObject___ctor__);
		  *(undefined4 *)(param1 + 0x2c) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002824 RID: 10276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002824")]
		[Address(RVA = "0x7949", Offset = "0x7949", VA = "0x7949")]
		public CollectionRowView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Inventory_View_Info_InfoBox_CollectionRowView___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  int *piVar4;
		  int iVar5;
		  
		  if (DAT_ram_00a5a0d9 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_DescriptionRow_TypeInfo);
		    DAT_ram_00a5a0d9 = '\x01';
		  }
		  if (DAT_ram_00a5a0dd == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_InfoRows_IInformationRow_TypeInfo);
		    DAT_ram_00a5a0dd = '\x01';
		  }
		  uVar1 = 0;
		  piVar4 = (int *)param1[8];
		  iVar5 = *piVar4;
		  if (*(ushort *)(iVar5 + 0xb6) != 0) {
		    do {
		      if (Core_Data_InfoRows_IInformationRow_TypeInfo ==
		          *(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar5 + 0x58) + uVar1 * 8 + 4) * 8 + iVar5 + 200);
		        goto code_r0x811c78f9;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar5 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar4,Core_Data_InfoRows_IInformationRow_TypeInfo,1);
		code_r0x811c78f9:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar4,puVar2[1]);
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		            (param1,uVar3,*(undefined4 *)(*param1 + 0xf4));
		  piVar4 = (int *)param1[8];
		  if (piVar4 != (int *)0x0) {
		    if (((uint)*(byte *)(*piVar4 + 0xb8) <
		         (uint)*(byte *)(Core_Data_InfoRows_DescriptionRow_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*piVar4 + 100) +
		                 (uint)*(byte *)(Core_Data_InfoRows_DescriptionRow_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_InfoRows_DescriptionRow_TypeInfo)) {
		      System_Activator__CreateInstance(piVar4,Core_Data_InfoRows_DescriptionRow_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  (**(code **)((ulonglong)*(uint *)(*param1 + 0xf8) * 4))
		            (param1,piVar4 + 4,*(undefined4 *)(*param1 + 0xfc));
		  return;
		}
		*/

		}

		// Token: 0x0400161D RID: 5661
		[Token(Token = "0x400161D")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private CollectionView _collectionViewPrefab;

		// Token: 0x0400161E RID: 5662
		[Token(Token = "0x400161E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0400161F RID: 5663
		[Token(Token = "0x400161F")]
		[FieldOffset(Offset = "0x2C")]
		private List<GameObject> _instances;
	}
}

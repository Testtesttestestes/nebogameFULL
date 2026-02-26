using System;
using Gameplay.Auchan.View;
using Il2CppDummyDll;
using UI.Tabs;

namespace Gameplay.Auchan.UI
{
	// Token: 0x02000C7F RID: 3199
	[Token(Token = "0x2000C7F")]
	public class AuchanSubcategoriesTabBarItemData : TabBarItemData
	{
		// Token: 0x06004E18 RID: 19992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004E18")]
		[Address(RVA = "0x9C4B", Offset = "0x9C4B", VA = "0x9C4B")]
		public AuchanSubcategoriesTabBarItemData()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Auchan_UI_AuchanSubcategoriesTabBarItemData___ctor(int param1,undefined4 param2)
		
		{
		  int param2_00;
		  undefined4 uVar1;
		  int *param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5983c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_View_AuchanActionInfoDisplay_HandleItemBought__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Auchan_View_AuchanActionInfoDisplay__Awake_b__13_0__);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Events_UnityAction_TypeInfo);
		    DAT_ram_00a5983c = '\x01';
		  }
		  uVar2 = *(undefined4 *)(*(int *)(param1 + 0x40) + 0xb4);
		  uVar1 = unnamed_function_1417(UnityEngine_Events_UnityAction_TypeInfo);
		  Utils_ObjectUtils__IsNotNull
		            (uVar1,param1,Method_Gameplay_Auchan_View_AuchanActionInfoDisplay__Awake_b__13_0__,0);
		  Gameplay_Boss_View_CaptainTab_BossInfoView__add_AttackButtonClickEvent(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)
		           (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10);
		  uVar1 = unnamed_function_1417(System_Action_TypeInfo);
		  UnityEngine_Events_UnityEvent__AddListener
		            (uVar1,param1,Method_Gameplay_Auchan_View_AuchanActionInfoDisplay_HandleItemBought__,0);
		  param1_00 = (int *)UnityEngine_UI_Image__set_sprite(uVar2,uVar1,0);
		  param2_00 = System_Action_TypeInfo;
		  if (param1_00 == (int *)0x0) {
		    *(undefined4 *)
		     (*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10) = 0;
		    return;
		  }
		  if ((System_Action_TypeInfo == *param1_00) &&
		     (*(int **)(*(int *)(Gameplay_Inventory_Controller_ArtifactViewEvents_TypeInfo + 0x5c) + 0x10) =
		           param1_00, *param1_00 == param2_00)) {
		    return;
		  }
		  System_Activator__CreateInstance(param1_00,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x04002A99 RID: 10905
		[Token(Token = "0x4002A99")]
		[FieldOffset(Offset = "0x20")]
		public AuchanArtifactCategoryData ArtifactCategoryData;
	}
}

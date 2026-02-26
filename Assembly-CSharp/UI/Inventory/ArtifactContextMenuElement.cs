using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Inventory.ContextMenu;
using Gameplay.Tutorial.Guide.Model.Data;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UI.Inventory
{
	// Token: 0x0200025D RID: 605
	[Token(Token = "0x200025D")]
	public class ArtifactContextMenuElement : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerClickHandler
	{
		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000E99 RID: 3737 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170001F8")]
		public IGuideTarget GuideTarget
		{
			[Token(Token = "0x6000E99")]
			[Address(RVA = "0x611A", Offset = "0x611A", VA = "0x611A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000E9A RID: 3738 RVA: 0x00004290 File Offset: 0x00002490
		// (set) Token: 0x06000E9B RID: 3739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001F9")]
		public bool ButtonBehaviour
		{
			[Token(Token = "0x6000E9A")]
			[Address(RVA = "0x611B", Offset = "0x611B", VA = "0x611B")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000E9B")]
			[Address(RVA = "0x611C", Offset = "0x611C", VA = "0x611C")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x140000F6 RID: 246
		// (add) Token: 0x06000E9C RID: 3740 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000E9D RID: 3741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000F6")]
		public event Action<ArtifactContextMenuElement> SelectEvent
		{
			[Token(Token = "0x6000E9C")]
			[Address(RVA = "0x611D", Offset = "0x611D", VA = "0x611D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000E9D")]
			[Address(RVA = "0x2149", Offset = "0x2149", VA = "0x2149")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000E9E RID: 3742 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000E9F RID: 3743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001FA")]
		public AbstractArtifactContextMenuElement AbstractContextMenuElement
		{
			[Token(Token = "0x6000E9E")]
			[Address(RVA = "0x611E", Offset = "0x611E", VA = "0x611E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000E9F")]
			[Address(RVA = "0x611F", Offset = "0x611F", VA = "0x611F")]
			set
			{
			}
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA0")]
		[Address(RVA = "0x6120", Offset = "0x6120", VA = "0x6120", Slot = "4")]
		public void OnPointerDown(PointerEventData eventData)
		{
		/* --- GHIDRA: OnPointerDown ---
		void UI_Inventory_ArtifactContextMenuElement__OnPointerDown
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (((*(int *)(param1 + 0x34) != 0) && (*(char *)(param1 + 0x2c) != '\0')) &&
		     (iVar1 = *(int *)(param1 + 0x30), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA1")]
		[Address(RVA = "0x6121", Offset = "0x6121", VA = "0x6121", Slot = "5")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EA2")]
		[Address(RVA = "0x6122", Offset = "0x6122", VA = "0x6122")]
		public ArtifactContextMenuElement()
		{
		}

		// Token: 0x04000754 RID: 1876
		[Token(Token = "0x4000754")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _label;

		// Token: 0x04000755 RID: 1877
		[Token(Token = "0x4000755")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Image _bg;

		// Token: 0x04000756 RID: 1878
		[Token(Token = "0x4000756")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameRawImageLoader _iconLoader;

		// Token: 0x04000757 RID: 1879
		[Token(Token = "0x4000757")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Transform _labelGroup;

		// Token: 0x04000758 RID: 1880
		[Token(Token = "0x4000758")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Sprite _enabledBgSprite;

		// Token: 0x04000759 RID: 1881
		[Token(Token = "0x4000759")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Sprite _disabledBgSprite;

		// Token: 0x0400075A RID: 1882
		[Token(Token = "0x400075A")]
		[FieldOffset(Offset = "0x28")]
		private IGuideTarget _guideTarget;

		// Token: 0x0400075D RID: 1885
		[Token(Token = "0x400075D")]
		[FieldOffset(Offset = "0x34")]
		private AbstractArtifactContextMenuElement _abstractContextMenuElement;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ButtonBehaviour ---
		void UI_Inventory_ArtifactContextMenuElement__set_ButtonBehaviour
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a639cf == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_ArtifactContextMenuElement__TypeInfo);
		    DAT_ram_00a639cf = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_ArtifactContextMenuElement__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_ArtifactContextMenuElement__TypeInfo),
		       iVar2 == 0)) break;
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


		/* --- GHIDRA: remove_SelectEvent ---
		int * UI_Inventory_ArtifactContextMenuElement__remove_SelectEvent(int *param1)
		
		{
		  if (*param1 == 0) {
		    return param1;
		  }
		  System_Data_DataSet__ValidateLocaleConstraint(*param1);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_AbstractContextMenuElement ---
		void UI_Inventory_ArtifactContextMenuElement__get_AbstractContextMenuElement
		               (int param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a639d1 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a639d1 = '\x01';
		  }
		  *(int *)(param1 + 0x34) = param2;
		  param1_00 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                        (*(undefined4 *)(param1 + 0x1c),0);
		  if (param2 != 0) {
		    Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		              (param1_00,1,0);
		    iVar1 = **(int **)(param1 + 0x10);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		              (*(int **)(param1 + 0x10),*(undefined4 *)(*(int *)(param1 + 0x34) + 8),
		               *(undefined4 *)(iVar1 + 0x2d4));
		    func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x20),0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (*(undefined4 *)(param1 + 0x18),*(undefined4 *)(*(int *)(param1 + 0x34) + 0x10),
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    return;
		  }
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (param1_00,0,0);
		  func_ii_7050(*(undefined4 *)(param1 + 0x14),*(undefined4 *)(param1 + 0x24),0);
		  return;
		}
		*/


		/* --- GHIDRA: set_AbstractContextMenuElement ---
		void UI_Inventory_ArtifactContextMenuElement__set_AbstractContextMenuElement
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  if (((*(int *)(param1 + 0x34) != 0) && (*(char *)(param1 + 0x2c) == '\0')) &&
		     (iVar1 = *(int *)(param1 + 0x30), iVar1 != 0)) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),param1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

}

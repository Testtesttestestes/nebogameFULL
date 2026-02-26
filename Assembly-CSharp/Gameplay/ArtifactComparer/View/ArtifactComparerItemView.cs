using System;
using AssetContent.Loaders;
using Core.Data;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;

namespace Gameplay.ArtifactComparer.View
{
	// Token: 0x02000CD2 RID: 3282
	[Token(Token = "0x2000CD2")]
	public class ArtifactComparerItemView : AbstractDataRenderer<ArtifactData>
	{
		// Token: 0x06004FE9 RID: 20457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FE9")]
		[Address(RVA = "0x9DFD", Offset = "0x9DFD", VA = "0x9DFD", Slot = "9")]
		protected override void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerItemView__Awake(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int *piVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a58a01 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2644);
		    DAT_ram_00a58a01 = '\x01';
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  piVar3 = (int *)param1[9];
		  if (iVar1 == 0) {
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		              (piVar3,0,*(undefined4 *)(*piVar3 + 0x13c));
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (param1[10],0,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    piVar3 = (int *)param1[0xb];
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar2 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_2644,1,0,1,0,0,0,0);
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  else {
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    (**(code **)((ulonglong)*(uint *)(*piVar3 + 0x138) * 4))
		              (piVar3,uVar2,*(undefined4 *)(*piVar3 + 0x13c));
		    iVar4 = param1[10];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Data_ArtikulData__get_BigBgSubstrateAssetId(uVar2,0);
		    Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		              (iVar4,uVar2,
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_Image__Sprite__set_AssetId__);
		    piVar3 = (int *)param1[0xb];
		    uVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    uVar2 = Core_Data_ArtikulData__get_IsSellable(uVar2,0);
		    iVar4 = *piVar3;
		    (**(code **)((ulonglong)*(uint *)(iVar4 + 0x2d0) * 4))
		              (piVar3,uVar2,*(undefined4 *)(iVar4 + 0x2d4));
		  }
		  uVar2 = System_Collections_Generic_Dictionary_ValueCollection_Enumerator_uint__object___MoveNext
		                    (param1[9],0);
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__UpdateAsText
		            (uVar2,(uint)(iVar1 != 0),0);
		  return;
		}
		*/

		}

		// Token: 0x06004FEA RID: 20458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEA")]
		[Address(RVA = "0x9DFE", Offset = "0x9DFE", VA = "0x9DFE", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_ArtifactComparer_View_ArtifactComparerItemView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58a02 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		    DAT_ram_00a58a02 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ArtifactData___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06004FEB RID: 20459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004FEB")]
		[Address(RVA = "0x9DFF", Offset = "0x9DFF", VA = "0x9DFF")]
		public ArtifactComparerItemView()
		{
		}

		// Token: 0x04002B79 RID: 11129
		[Token(Token = "0x4002B79")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ArtifactView _artifactView;

		// Token: 0x04002B7A RID: 11130
		[Token(Token = "0x4002B7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameImageLoader _bgImageLoader;

		// Token: 0x04002B7B RID: 11131
		[Token(Token = "0x4002B7B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _title;
	}
}

using System;
using Gameplay.Clans.Office.View;
using Gameplay.Isles.Clan;
using Il2CppDummyDll;
using UI;
using UI.ToolTip;
using UnityEngine;

namespace Gameplay.UserInterface.View
{
	// Token: 0x020003BA RID: 954
	[Token(Token = "0x20003BA")]
	public class ClanIndexView : AbstractDataRenderer<ClanIsle>, IToolTipDataProvider
	{
		// Token: 0x06001663 RID: 5731 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001663")]
		[Address(RVA = "0x6824", Offset = "0x6824", VA = "0x6824", Slot = "20")]
		public BaseToolTipData GetData()
		{
		/* --- GHIDRA: GetData ---
		void Gameplay_UserInterface_View_ClanIndexView__GetData(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int param2_00;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a58258 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_ClanIsleEvents__ClanIsleModel__ClanIsleController__ClanBuildingTypes__get_Model__
		              );
		    DAT_ram_00a58258 = '\x01';
		  }
		  iVar1 = Cysharp_Threading_Tasks_CancellationTokenExtensions___cctor(param1[0xb],0);
		  if (iVar1 != 0) {
		    iVar2 = param1[0xb];
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    UI_ToolTip_ToolTip__get_enabled(iVar2,(uint)(iVar1 != 0),0);
		  }
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x134));
		  if (iVar1 != 0) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x130) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x134));
		    iVar2 = param1[9];
		    param2_00 = *(int *)(*(int *)(iVar1 + 0x10) + 0x30);
		    uVar4 = *(undefined4 *)(*(int *)(param2_00 + 0x1c) + 0x18);
		    iVar1 = System_Collections_CollectionBase___ctor(*(undefined4 *)(iVar2 + 0x1c),uVar4,0);
		    if (iVar1 == 0) {
		      *(undefined4 *)(iVar2 + 0x1c) = uVar4;
		      iVar1 = **(int **)(iVar2 + 0x10);
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0x2d0) * 4))
		                (*(int **)(iVar2 + 0x10),uVar4,*(undefined4 *)(iVar1 + 0x2d4));
		    }
		    iVar1 = param1[10];
		    if (param2_00 != *(int *)(iVar1 + 0x1c)) {
		      *(int *)(iVar1 + 0x1c) = param2_00;
		      Gameplay_UserInterface_View_ClanLeagueBannerView__set_ClanData(iVar1,param1);
		    }
		    Gameplay_Clans_Office_View_ClanCursesIndicator__OnDestroy(param1[0xc],param2_00,0);
		    iVar1 = *(int *)(param2_00 + 0x10);
		    iVar2 = param1[9];
		    if (iVar1 != *(int *)(iVar2 + 0x20)) {
		      *(int *)(iVar2 + 0x20) = iVar1;
		      if (DAT_ram_00a5825b == '\0') {
		        Mono_Security_ASN1__get_Item
		                  (&
		                   Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                  );
		        DAT_ram_00a5825b = '\x01';
		        iVar1 = *(int *)(iVar2 + 0x20);
		      }
		      uVar3 = *(undefined4 *)(iVar2 + 0x14);
		      uVar4 = Core_Extensions_Dict_ClanCultDicExt__GetClanCultBgAssetId(iVar1,0);
		      Core_Extensions_Dict_ResourcesDicExt__GetIconForResourceBar64AssetId(uVar3,uVar4,0);
		      uVar3 = *(undefined4 *)(iVar2 + 0x18);
		      uVar4 = Core_Extensions_Dict_ClanCultDicExt__GetDecorDotForBannerAssetId
		                        (*(undefined4 *)(iVar2 + 0x20),0);
		      Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		                (uVar3,uVar4,
		                 Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		                );
		    }
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06001664 RID: 5732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001664")]
		[Address(RVA = "0x6825", Offset = "0x6825", VA = "0x6825", Slot = "19")]
		protected override void HandleDataChanged()
		{
		/* --- GHIDRA: HandleDataChanged ---
		void Gameplay_UserInterface_View_ClanIndexView__HandleDataChanged
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58259 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_AbstractDataRenderer_ClanIsle___ctor__);
		    DAT_ram_00a58259 = '\x01';
		  }
		  UnityEngine_ParticleSystemRenderer__GetMeshes
		            (param1,Method_UI_AbstractDataRenderer_ClanIsle___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x06001665 RID: 5733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001665")]
		[Address(RVA = "0x6826", Offset = "0x6826", VA = "0x6826")]
		public ClanIndexView()
		{
		}

		// Token: 0x04000BBD RID: 3005
		[Token(Token = "0x4000BBD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private ClanNickCultIndexView _nickCultIndexView;

		// Token: 0x04000BBE RID: 3006
		[Token(Token = "0x4000BBE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClanLeagueBannerView _clanLeagueBannerView;

		// Token: 0x04000BBF RID: 3007
		[Token(Token = "0x4000BBF")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private ToolTip _toolTip;

		// Token: 0x04000BC0 RID: 3008
		[Token(Token = "0x4000BC0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClanCursesIndicator _restrictionsIndicator;
	}
}

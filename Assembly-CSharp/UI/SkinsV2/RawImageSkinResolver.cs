using System;
using System.Threading;
using Core.Gameplay.Managers.Skins;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace UI.SkinsV2
{
	// Token: 0x02000187 RID: 391
	[Token(Token = "0x2000187")]
	[AddComponentMenu("SkinsV2/RawImageSkin (Skin Resolver)")]
	[DisallowMultipleComponent]
	public class RawImageSkinResolver : AbstractSkinResolver<RawImage, Texture>
	{
		// Token: 0x06000B00 RID: 2816 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B00")]
		[Address(RVA = "0x5E22", Offset = "0x5E22", VA = "0x5E22", Slot = "4")]
		protected override void GetDefaultContent(RawImage component, out AbstractSkinResolver<RawImage, Texture>.ContentInfo content)
		{
		/* --- GHIDRA: GetDefaultContent ---
		void UI_SkinsV2_RawImageSkinResolver__GetDefaultContent
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  Com_TheFallenGames_OSA_CustomAdapters_TableView_Tuple_Basic_BasicTupleValueViewsHolder__ActivatePanelOnlyFor
		            (param2,param3,0);
		  return;
		}
		*/

		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B01")]
		[Address(RVA = "0x5E23", Offset = "0x5E23", VA = "0x5E23", Slot = "5")]
		protected override void Rollback(RawImage component, Texture content)
		{
		/* --- GHIDRA: Rollback ---
		void UI_SkinsV2_RawImageSkinResolver__Rollback
		               (undefined8 *param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  undefined1 auStack_40 [8];
		  undefined8 local_38;
		  undefined4 local_30;
		  undefined8 local_2c;
		  undefined4 local_24;
		  undefined4 local_20;
		  undefined4 local_1c;
		  undefined4 local_18;
		  undefined4 local_14;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  if (DAT_ram_00a599ef == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Create__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_RawImageSkinResolver__TryResolve_d__5___
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		              );
		    DAT_ram_00a599ef = '\x01';
		  }
		  local_8 = 0;
		  local_24 = 0;
		  local_10 = 0;
		  local_2c = 0;
		  local_30 = 0xffffffff;
		  local_20 = param2;
		  local_1c = param3;
		  local_18 = param4;
		  local_14 = param5;
		  if (*(int *)(
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_RawImageSkinResolver__TryResolve_d__5___
		              + 0x1c) == 0) {
		    System_ReadOnlySpan_char___GetPinnableReference
		              (
		              Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__Start_RawImageSkinResolver__TryResolve_d__5___
		              );
		  }
		  UI_SkinsV2_RawImageSkinResolver_WrapMode___ctor(&local_30,auStack_40);
		  unnamed_function_62983
		            (&local_38,&local_2c,
		             Method_Cysharp_Threading_Tasks_CompilerServices_AsyncUniTaskMethodBuilder_bool__get_Task__
		            );
		  *param1 = local_38;
		  return;
		}
		*/

		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x00003A80 File Offset: 0x00001C80
		[Token(Token = "0x6000B02")]
		[Address(RVA = "0x5E24", Offset = "0x5E24", VA = "0x5E24", Slot = "6")]
		protected override UniTask<bool> TryResolve(RawImage component, Skin skin, CancellationToken cancellationToken)
		{
		/* --- GHIDRA: TryResolve ---
		void UI_SkinsV2_RawImageSkinResolver__TryResolve(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a599f0 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_UI_SkinsV2_AbstractSkinResolver_RawImage__Texture___ctor__)
		    ;
		    DAT_ram_00a599f0 = '\x01';
		  }
		  Gameplay_Combat_Model_SkillsChange_AbstractShortSpellInfo_object___Dispose
		            (param1,Method_UI_SkinsV2_AbstractSkinResolver_RawImage__Texture___ctor__);
		  return;
		}
		*/

			return default(UniTask<bool>);
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B03")]
		[Address(RVA = "0x5E25", Offset = "0x5E25", VA = "0x5E25")]
		public RawImageSkinResolver()
		{
		}

		// Token: 0x040004EF RID: 1263
		[Token(Token = "0x40004EF")]
		[FieldOffset(Offset = "0x20")]
		private string _textureName;

		// Token: 0x040004F0 RID: 1264
		[Token(Token = "0x40004F0")]
		[FieldOffset(Offset = "0x24")]
		private RawImageSkinResolver.WrapMode _wrapMode;

		// Token: 0x02000188 RID: 392
		[Token(Token = "0x2000188")]
		private class WrapMode
		{
			// Token: 0x06000B04 RID: 2820 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000B04")]
			[Address(RVA = "0x5E26", Offset = "0x5E26", VA = "0x5E26")]
			public WrapMode(TextureWrapMode common, TextureWrapMode u, TextureWrapMode v, TextureWrapMode w)
			{
			}

			// Token: 0x040004F1 RID: 1265
			[Token(Token = "0x40004F1")]
			[FieldOffset(Offset = "0x8")]
			public readonly TextureWrapMode Common;

			// Token: 0x040004F2 RID: 1266
			[Token(Token = "0x40004F2")]
			[FieldOffset(Offset = "0xC")]
			public readonly TextureWrapMode U;

			// Token: 0x040004F3 RID: 1267
			[Token(Token = "0x40004F3")]
			[FieldOffset(Offset = "0x10")]
			public readonly TextureWrapMode V;

			// Token: 0x040004F4 RID: 1268
			[Token(Token = "0x40004F4")]
			[FieldOffset(Offset = "0x14")]
			public readonly TextureWrapMode W;
		}
	}
}

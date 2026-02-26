using System;
using Il2CppDummyDll;
using Protocol.Dic;
using UnityEngine;

namespace Core.Cache.Audio
{
	// Token: 0x0200110B RID: 4363
	[Token(Token = "0x200110B")]
	public class AudioClipCache : AbstractCache<AssetDic, AudioClip>
	{
		// Token: 0x060065D2 RID: 26066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D2")]
		[Address(RVA = "0xB15B", Offset = "0xB15B", VA = "0xB15B")]
		public AudioClipCache(float ttl)
		{
		/* --- GHIDRA: .ctor ---
		int Core_Cache_Audio_AudioClipCache___ctor(undefined4 param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  int iVar2;
		  undefined4 param1_00;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a5a8d8 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Core_Cache_AbstractCache_AssetDic__AudioClip__Reset__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    DAT_ram_00a5a8d8 = '\x01';
		  }
		  Core_Cache_AbstractCache_object__object___GetDataNext
		            (param1,param2,Method_Core_Cache_AbstractCache_AssetDic__AudioClip__Reset__);
		  iVar2 = *(int *)(param2 + 0xc);
		  if (0 < iVar2) {
		    do {
		      param1_00 = *(undefined4 *)(*(int *)(param2 + iVar1 * 4 + 0x10) + 0x14);
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__GetAudioClip(param1_00,0);
		      iVar1 = iVar1 + 1;
		      iVar2 = *(int *)(param2 + 0xc);
		    } while (iVar1 < iVar2);
		  }
		  return iVar2;
		}
		*/

		}

		// Token: 0x060065D3 RID: 26067 RVA: 0x000136C8 File Offset: 0x000118C8
		[Token(Token = "0x60065D3")]
		[Address(RVA = "0xB15C", Offset = "0xB15C", VA = "0xB15C", Slot = "10")]
		public override int Reset(params AssetDic[] keys)
		{
		/* --- GHIDRA: Reset ---
		void Core_Cache_Audio_AudioClipCache__Reset
		               (undefined4 param1,undefined8 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5)
		
		{
		  int iVar1;
		  int param2_00;
		  int param1_00;
		  undefined4 uVar2;
		  
		  if (DAT_ram_00a5a8d9 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_AssetDic__AudioClip__AddCallback__);
		    Mono_Security_ASN1__get_Item
		              (&Core_GameResources_GameResourcesManager_AudioClipReadyDelegate_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UnityEngine_AudioClip___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_AbstractCache_CacheItem_AssetDic__AudioClip__get_Key__);
		    Mono_Security_ASN1__get_Item(&Core_GameResources_GameResourcesManager_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Core_Cache_Audio_AudioClipCache___c__DisplayClass2_0__Update_b__0__);
		    Mono_Security_ASN1__get_Item(&Core_Cache_Audio_AudioClipCache___c__DisplayClass2_0_TypeInfo);
		    DAT_ram_00a5a8d9 = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Core_Cache_Audio_AudioClipCache___c__DisplayClass2_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0x10) = param4;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  Core_Cache_AbstractCache_ulong__object____ctor
		            (param1,param4,param2,param3,
		             Method_Core_Cache_AbstractCache_AssetDic__AudioClip__AddCallback__);
		  uVar2 = *(undefined4 *)(*(int *)(param2_00 + 0x10) + 0xc);
		  *(undefined4 *)(param2_00 + 0x18) = uVar2;
		  *(undefined4 *)(param2_00 + 0xc) = 0;
		  uVar2 = Mono_Security_ASN1Convert__ToOid(UnityEngine_AudioClip___TypeInfo,uVar2);
		  *(undefined4 *)(param2_00 + 0x14) = uVar2;
		  if (0 < *(int *)(param2_00 + 0x18)) {
		    iVar1 = 0;
		    do {
		      uVar2 = *(undefined4 *)
		               (*(int *)(*(int *)(*(int *)(param2_00 + 0x10) + iVar1 * 4 + 0x10) + 8) + 0x14);
		      param1_00 = *(int *)(param2_00 + 0x1c);
		      if (param1_00 == 0) {
		        param1_00 = unnamed_function_1417
		                              (
		                              Core_GameResources_GameResourcesManager_AudioClipReadyDelegate_TypeInfo
		                              );
		        Core_GameResources_GameResourcesManager_TextMeshProSpriteAssetReadyDelegate__EndInvoke
		                  (param1_00,param2_00,
		                   Method_Core_Cache_Audio_AudioClipCache___c__DisplayClass2_0__Update_b__0__,0);
		        *(int *)(param2_00 + 0x1c) = param1_00;
		      }
		      if (*(int *)(Core_GameResources_GameResourcesManager_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameResources_GameResourcesManager_TypeInfo);
		      }
		      Core_GameResources_GameResourcesManager__GetTextMeshProSpriteAsset(uVar2,param1_00,0,1,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2_00 + 0x18));
		  }
		  return;
		}
		*/

			return 0;
		}

		// Token: 0x060065D4 RID: 26068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60065D4")]
		[Address(RVA = "0xB15D", Offset = "0xB15D", VA = "0xB15D", Slot = "11")]
		protected override void Update(long requestIndex, CacheResultCallback<AudioClip> completeCallback, params AbstractCache<AssetDic, AudioClip>.CacheItem[] cacheItems)
		{
		}
	}
}

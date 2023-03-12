using HarmonyLib;
using WrestlingEmpireTemplateMod;

namespace WECCL.Patches;

[HarmonyPatch]
public class LimitPatch
{
    [HarmonyPatch(typeof(KILNEHBPDGI), "NLFDGDOOAOK")]
    [HarmonyPostfix]
    public static void KILNEHBPDGI_NLFDGDOOAOK()
    {
        NODLGBMEKCI.BLPHAAGAAIH = Plugin.ActualCharacterLimit.Value;
        KILNEHBPDGI.EFNPMNFJBIA = Plugin.ActualCharacterLimit.Value;
    }
}
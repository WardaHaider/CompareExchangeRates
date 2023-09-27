// <copyright file="IcffEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace ImageCharts.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using ImageCharts.Standard;
    using ImageCharts.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// IcffEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum IcffEnum
    {
        /// <summary>
        /// ABeeZee.
        /// </summary>
        [EnumMember(Value = "ABeeZee")]
        ABeeZee,

        /// <summary>
        /// Abel.
        /// </summary>
        [EnumMember(Value = "Abel")]
        Abel,

        /// <summary>
        /// EnumAbhayaLibre.
        /// </summary>
        [EnumMember(Value = "Abhaya Libre")]
        EnumAbhayaLibre,

        /// <summary>
        /// EnumAbrilFatface.
        /// </summary>
        [EnumMember(Value = "Abril Fatface")]
        EnumAbrilFatface,

        /// <summary>
        /// Aclonica.
        /// </summary>
        [EnumMember(Value = "Aclonica")]
        Aclonica,

        /// <summary>
        /// Acme.
        /// </summary>
        [EnumMember(Value = "Acme")]
        Acme,

        /// <summary>
        /// Actor.
        /// </summary>
        [EnumMember(Value = "Actor")]
        Actor,

        /// <summary>
        /// Adamina.
        /// </summary>
        [EnumMember(Value = "Adamina")]
        Adamina,

        /// <summary>
        /// EnumAdventPro.
        /// </summary>
        [EnumMember(Value = "Advent Pro")]
        EnumAdventPro,

        /// <summary>
        /// EnumAguafinaScript.
        /// </summary>
        [EnumMember(Value = "Aguafina Script")]
        EnumAguafinaScript,

        /// <summary>
        /// Akronim.
        /// </summary>
        [EnumMember(Value = "Akronim")]
        Akronim,

        /// <summary>
        /// Aladin.
        /// </summary>
        [EnumMember(Value = "Aladin")]
        Aladin,

        /// <summary>
        /// Aldrich.
        /// </summary>
        [EnumMember(Value = "Aldrich")]
        Aldrich,

        /// <summary>
        /// Alef.
        /// </summary>
        [EnumMember(Value = "Alef")]
        Alef,

        /// <summary>
        /// Alegreya.
        /// </summary>
        [EnumMember(Value = "Alegreya")]
        Alegreya,

        /// <summary>
        /// EnumAlegreyaSC.
        /// </summary>
        [EnumMember(Value = "Alegreya SC")]
        EnumAlegreyaSC,

        /// <summary>
        /// EnumAlegreyaSans.
        /// </summary>
        [EnumMember(Value = "Alegreya Sans")]
        EnumAlegreyaSans,

        /// <summary>
        /// EnumAlegreyaSansSC.
        /// </summary>
        [EnumMember(Value = "Alegreya Sans SC")]
        EnumAlegreyaSansSC,

        /// <summary>
        /// Aleo.
        /// </summary>
        [EnumMember(Value = "Aleo")]
        Aleo,

        /// <summary>
        /// EnumAlexBrush.
        /// </summary>
        [EnumMember(Value = "Alex Brush")]
        EnumAlexBrush,

        /// <summary>
        /// EnumAlfaSlabOne.
        /// </summary>
        [EnumMember(Value = "Alfa Slab One")]
        EnumAlfaSlabOne,

        /// <summary>
        /// Alice.
        /// </summary>
        [EnumMember(Value = "Alice")]
        Alice,

        /// <summary>
        /// Alike.
        /// </summary>
        [EnumMember(Value = "Alike")]
        Alike,

        /// <summary>
        /// EnumAlikeAngular.
        /// </summary>
        [EnumMember(Value = "Alike Angular")]
        EnumAlikeAngular,

        /// <summary>
        /// Allan.
        /// </summary>
        [EnumMember(Value = "Allan")]
        Allan,

        /// <summary>
        /// Allerta.
        /// </summary>
        [EnumMember(Value = "Allerta")]
        Allerta,

        /// <summary>
        /// EnumAllertaStencil.
        /// </summary>
        [EnumMember(Value = "Allerta Stencil")]
        EnumAllertaStencil,

        /// <summary>
        /// Allura.
        /// </summary>
        [EnumMember(Value = "Allura")]
        Allura,

        /// <summary>
        /// Almarai.
        /// </summary>
        [EnumMember(Value = "Almarai")]
        Almarai,

        /// <summary>
        /// Almendra.
        /// </summary>
        [EnumMember(Value = "Almendra")]
        Almendra,

        /// <summary>
        /// EnumAlmendraDisplay.
        /// </summary>
        [EnumMember(Value = "Almendra Display")]
        EnumAlmendraDisplay,

        /// <summary>
        /// EnumAlmendraSC.
        /// </summary>
        [EnumMember(Value = "Almendra SC")]
        EnumAlmendraSC,

        /// <summary>
        /// Amarante.
        /// </summary>
        [EnumMember(Value = "Amarante")]
        Amarante,

        /// <summary>
        /// Amaranth.
        /// </summary>
        [EnumMember(Value = "Amaranth")]
        Amaranth,

        /// <summary>
        /// EnumAmaticSC.
        /// </summary>
        [EnumMember(Value = "Amatic SC")]
        EnumAmaticSC,

        /// <summary>
        /// Amethysta.
        /// </summary>
        [EnumMember(Value = "Amethysta")]
        Amethysta,

        /// <summary>
        /// Amiko.
        /// </summary>
        [EnumMember(Value = "Amiko")]
        Amiko,

        /// <summary>
        /// Amiri.
        /// </summary>
        [EnumMember(Value = "Amiri")]
        Amiri,

        /// <summary>
        /// Amita.
        /// </summary>
        [EnumMember(Value = "Amita")]
        Amita,

        /// <summary>
        /// Anaheim.
        /// </summary>
        [EnumMember(Value = "Anaheim")]
        Anaheim,

        /// <summary>
        /// Andada.
        /// </summary>
        [EnumMember(Value = "Andada")]
        Andada,

        /// <summary>
        /// Andika.
        /// </summary>
        [EnumMember(Value = "Andika")]
        Andika,

        /// <summary>
        /// Angkor.
        /// </summary>
        [EnumMember(Value = "Angkor")]
        Angkor,

        /// <summary>
        /// EnumAnnieUseYourTelescope.
        /// </summary>
        [EnumMember(Value = "Annie Use Your Telescope")]
        EnumAnnieUseYourTelescope,

        /// <summary>
        /// EnumAnonymousPro.
        /// </summary>
        [EnumMember(Value = "Anonymous Pro")]
        EnumAnonymousPro,

        /// <summary>
        /// Antic.
        /// </summary>
        [EnumMember(Value = "Antic")]
        Antic,

        /// <summary>
        /// EnumAnticDidone.
        /// </summary>
        [EnumMember(Value = "Antic Didone")]
        EnumAnticDidone,

        /// <summary>
        /// EnumAnticSlab.
        /// </summary>
        [EnumMember(Value = "Antic Slab")]
        EnumAnticSlab,

        /// <summary>
        /// Anton.
        /// </summary>
        [EnumMember(Value = "Anton")]
        Anton,

        /// <summary>
        /// Arapey.
        /// </summary>
        [EnumMember(Value = "Arapey")]
        Arapey,

        /// <summary>
        /// Arbutus.
        /// </summary>
        [EnumMember(Value = "Arbutus")]
        Arbutus,

        /// <summary>
        /// EnumArbutusSlab.
        /// </summary>
        [EnumMember(Value = "Arbutus Slab")]
        EnumArbutusSlab,

        /// <summary>
        /// EnumArchitectsDaughter.
        /// </summary>
        [EnumMember(Value = "Architects Daughter")]
        EnumArchitectsDaughter,

        /// <summary>
        /// Archivo.
        /// </summary>
        [EnumMember(Value = "Archivo")]
        Archivo,

        /// <summary>
        /// EnumArchivoBlack.
        /// </summary>
        [EnumMember(Value = "Archivo Black")]
        EnumArchivoBlack,

        /// <summary>
        /// EnumArchivoNarrow.
        /// </summary>
        [EnumMember(Value = "Archivo Narrow")]
        EnumArchivoNarrow,

        /// <summary>
        /// EnumArefRuqaa.
        /// </summary>
        [EnumMember(Value = "Aref Ruqaa")]
        EnumArefRuqaa,

        /// <summary>
        /// EnumArimaMadurai.
        /// </summary>
        [EnumMember(Value = "Arima Madurai")]
        EnumArimaMadurai,

        /// <summary>
        /// Arimo.
        /// </summary>
        [EnumMember(Value = "Arimo")]
        Arimo,

        /// <summary>
        /// Arizonia.
        /// </summary>
        [EnumMember(Value = "Arizonia")]
        Arizonia,

        /// <summary>
        /// Armata.
        /// </summary>
        [EnumMember(Value = "Armata")]
        Armata,

        /// <summary>
        /// Arsenal.
        /// </summary>
        [EnumMember(Value = "Arsenal")]
        Arsenal,

        /// <summary>
        /// Artifika.
        /// </summary>
        [EnumMember(Value = "Artifika")]
        Artifika,

        /// <summary>
        /// Arvo.
        /// </summary>
        [EnumMember(Value = "Arvo")]
        Arvo,

        /// <summary>
        /// Arya.
        /// </summary>
        [EnumMember(Value = "Arya")]
        Arya,

        /// <summary>
        /// Asap.
        /// </summary>
        [EnumMember(Value = "Asap")]
        Asap,

        /// <summary>
        /// EnumAsapCondensed.
        /// </summary>
        [EnumMember(Value = "Asap Condensed")]
        EnumAsapCondensed,

        /// <summary>
        /// Asar.
        /// </summary>
        [EnumMember(Value = "Asar")]
        Asar,

        /// <summary>
        /// Asset.
        /// </summary>
        [EnumMember(Value = "Asset")]
        Asset,

        /// <summary>
        /// Assistant.
        /// </summary>
        [EnumMember(Value = "Assistant")]
        Assistant,

        /// <summary>
        /// Astloch.
        /// </summary>
        [EnumMember(Value = "Astloch")]
        Astloch,

        /// <summary>
        /// Asul.
        /// </summary>
        [EnumMember(Value = "Asul")]
        Asul,

        /// <summary>
        /// Athiti.
        /// </summary>
        [EnumMember(Value = "Athiti")]
        Athiti,

        /// <summary>
        /// Atma.
        /// </summary>
        [EnumMember(Value = "Atma")]
        Atma,

        /// <summary>
        /// EnumAtomicAge.
        /// </summary>
        [EnumMember(Value = "Atomic Age")]
        EnumAtomicAge,

        /// <summary>
        /// Aubrey.
        /// </summary>
        [EnumMember(Value = "Aubrey")]
        Aubrey,

        /// <summary>
        /// Audiowide.
        /// </summary>
        [EnumMember(Value = "Audiowide")]
        Audiowide,

        /// <summary>
        /// EnumAutourOne.
        /// </summary>
        [EnumMember(Value = "Autour One")]
        EnumAutourOne,

        /// <summary>
        /// Average.
        /// </summary>
        [EnumMember(Value = "Average")]
        Average,

        /// <summary>
        /// EnumAverageSans.
        /// </summary>
        [EnumMember(Value = "Average Sans")]
        EnumAverageSans,

        /// <summary>
        /// EnumAveriaGruesaLibre.
        /// </summary>
        [EnumMember(Value = "Averia Gruesa Libre")]
        EnumAveriaGruesaLibre,

        /// <summary>
        /// EnumAveriaLibre.
        /// </summary>
        [EnumMember(Value = "Averia Libre")]
        EnumAveriaLibre,

        /// <summary>
        /// EnumAveriaSansLibre.
        /// </summary>
        [EnumMember(Value = "Averia Sans Libre")]
        EnumAveriaSansLibre,

        /// <summary>
        /// EnumAveriaSerifLibre.
        /// </summary>
        [EnumMember(Value = "Averia Serif Libre")]
        EnumAveriaSerifLibre,

        /// <summary>
        /// B612.
        /// </summary>
        [EnumMember(Value = "B612")]
        B612,

        /// <summary>
        /// EnumB612Mono.
        /// </summary>
        [EnumMember(Value = "B612 Mono")]
        EnumB612Mono,

        /// <summary>
        /// EnumBadScript.
        /// </summary>
        [EnumMember(Value = "Bad Script")]
        EnumBadScript,

        /// <summary>
        /// Bahiana.
        /// </summary>
        [EnumMember(Value = "Bahiana")]
        Bahiana,

        /// <summary>
        /// Bahianita.
        /// </summary>
        [EnumMember(Value = "Bahianita")]
        Bahianita,

        /// <summary>
        /// EnumBaiJamjuree.
        /// </summary>
        [EnumMember(Value = "Bai Jamjuree")]
        EnumBaiJamjuree,

        /// <summary>
        /// Baloo.
        /// </summary>
        [EnumMember(Value = "Baloo")]
        Baloo,

        /// <summary>
        /// EnumBalooBhai.
        /// </summary>
        [EnumMember(Value = "Baloo Bhai")]
        EnumBalooBhai,

        /// <summary>
        /// EnumBalooBhaijaan.
        /// </summary>
        [EnumMember(Value = "Baloo Bhaijaan")]
        EnumBalooBhaijaan,

        /// <summary>
        /// EnumBalooBhaina.
        /// </summary>
        [EnumMember(Value = "Baloo Bhaina")]
        EnumBalooBhaina,

        /// <summary>
        /// EnumBalooChettan.
        /// </summary>
        [EnumMember(Value = "Baloo Chettan")]
        EnumBalooChettan,

        /// <summary>
        /// EnumBalooDa.
        /// </summary>
        [EnumMember(Value = "Baloo Da")]
        EnumBalooDa,

        /// <summary>
        /// EnumBalooPaaji.
        /// </summary>
        [EnumMember(Value = "Baloo Paaji")]
        EnumBalooPaaji,

        /// <summary>
        /// EnumBalooTamma.
        /// </summary>
        [EnumMember(Value = "Baloo Tamma")]
        EnumBalooTamma,

        /// <summary>
        /// EnumBalooTammudu.
        /// </summary>
        [EnumMember(Value = "Baloo Tammudu")]
        EnumBalooTammudu,

        /// <summary>
        /// EnumBalooThambi.
        /// </summary>
        [EnumMember(Value = "Baloo Thambi")]
        EnumBalooThambi,

        /// <summary>
        /// Balthazar.
        /// </summary>
        [EnumMember(Value = "Balthazar")]
        Balthazar,

        /// <summary>
        /// Bangers.
        /// </summary>
        [EnumMember(Value = "Bangers")]
        Bangers,

        /// <summary>
        /// Barlow.
        /// </summary>
        [EnumMember(Value = "Barlow")]
        Barlow,

        /// <summary>
        /// EnumBarlowCondensed.
        /// </summary>
        [EnumMember(Value = "Barlow Condensed")]
        EnumBarlowCondensed,

        /// <summary>
        /// EnumBarlowSemiCondensed.
        /// </summary>
        [EnumMember(Value = "Barlow Semi Condensed")]
        EnumBarlowSemiCondensed,

        /// <summary>
        /// Barriecito.
        /// </summary>
        [EnumMember(Value = "Barriecito")]
        Barriecito,

        /// <summary>
        /// Barrio.
        /// </summary>
        [EnumMember(Value = "Barrio")]
        Barrio,

        /// <summary>
        /// Basic.
        /// </summary>
        [EnumMember(Value = "Basic")]
        Basic,

        /// <summary>
        /// Battambang.
        /// </summary>
        [EnumMember(Value = "Battambang")]
        Battambang,

        /// <summary>
        /// Baumans.
        /// </summary>
        [EnumMember(Value = "Baumans")]
        Baumans,

        /// <summary>
        /// Bayon.
        /// </summary>
        [EnumMember(Value = "Bayon")]
        Bayon,

        /// <summary>
        /// EnumBeVietnam.
        /// </summary>
        [EnumMember(Value = "Be Vietnam")]
        EnumBeVietnam,

        /// <summary>
        /// Belgrano.
        /// </summary>
        [EnumMember(Value = "Belgrano")]
        Belgrano,

        /// <summary>
        /// Bellefair.
        /// </summary>
        [EnumMember(Value = "Bellefair")]
        Bellefair,

        /// <summary>
        /// Belleza.
        /// </summary>
        [EnumMember(Value = "Belleza")]
        Belleza,

        /// <summary>
        /// BenchNine.
        /// </summary>
        [EnumMember(Value = "BenchNine")]
        BenchNine,

        /// <summary>
        /// Bentham.
        /// </summary>
        [EnumMember(Value = "Bentham")]
        Bentham,

        /// <summary>
        /// EnumBerkshireSwash.
        /// </summary>
        [EnumMember(Value = "Berkshire Swash")]
        EnumBerkshireSwash,

        /// <summary>
        /// EnumBethEllen.
        /// </summary>
        [EnumMember(Value = "Beth Ellen")]
        EnumBethEllen,

        /// <summary>
        /// Bevan.
        /// </summary>
        [EnumMember(Value = "Bevan")]
        Bevan,

        /// <summary>
        /// EnumBigShouldersDisplay.
        /// </summary>
        [EnumMember(Value = "Big Shoulders Display")]
        EnumBigShouldersDisplay,

        /// <summary>
        /// EnumBigShouldersText.
        /// </summary>
        [EnumMember(Value = "Big Shoulders Text")]
        EnumBigShouldersText,

        /// <summary>
        /// EnumBigelowRules.
        /// </summary>
        [EnumMember(Value = "Bigelow Rules")]
        EnumBigelowRules,

        /// <summary>
        /// EnumBigshotOne.
        /// </summary>
        [EnumMember(Value = "Bigshot One")]
        EnumBigshotOne,

        /// <summary>
        /// Bilbo.
        /// </summary>
        [EnumMember(Value = "Bilbo")]
        Bilbo,

        /// <summary>
        /// EnumBilboSwashCaps.
        /// </summary>
        [EnumMember(Value = "Bilbo Swash Caps")]
        EnumBilboSwashCaps,

        /// <summary>
        /// BioRhyme.
        /// </summary>
        [EnumMember(Value = "BioRhyme")]
        BioRhyme,

        /// <summary>
        /// EnumBioRhymeExpanded.
        /// </summary>
        [EnumMember(Value = "BioRhyme Expanded")]
        EnumBioRhymeExpanded,

        /// <summary>
        /// Biryani.
        /// </summary>
        [EnumMember(Value = "Biryani")]
        Biryani,

        /// <summary>
        /// Bitter.
        /// </summary>
        [EnumMember(Value = "Bitter")]
        Bitter,

        /// <summary>
        /// EnumBlackAndWhitePicture.
        /// </summary>
        [EnumMember(Value = "Black And White Picture")]
        EnumBlackAndWhitePicture,

        /// <summary>
        /// EnumBlackHanSans.
        /// </summary>
        [EnumMember(Value = "Black Han Sans")]
        EnumBlackHanSans,

        /// <summary>
        /// EnumBlackOpsOne.
        /// </summary>
        [EnumMember(Value = "Black Ops One")]
        EnumBlackOpsOne,

        /// <summary>
        /// Blinker.
        /// </summary>
        [EnumMember(Value = "Blinker")]
        Blinker,

        /// <summary>
        /// Bokor.
        /// </summary>
        [EnumMember(Value = "Bokor")]
        Bokor,

        /// <summary>
        /// Bonbon.
        /// </summary>
        [EnumMember(Value = "Bonbon")]
        Bonbon,

        /// <summary>
        /// Boogaloo.
        /// </summary>
        [EnumMember(Value = "Boogaloo")]
        Boogaloo,

        /// <summary>
        /// EnumBowlbyOne.
        /// </summary>
        [EnumMember(Value = "Bowlby One")]
        EnumBowlbyOne,

        /// <summary>
        /// EnumBowlbyOneSC.
        /// </summary>
        [EnumMember(Value = "Bowlby One SC")]
        EnumBowlbyOneSC,

        /// <summary>
        /// Brawler.
        /// </summary>
        [EnumMember(Value = "Brawler")]
        Brawler,

        /// <summary>
        /// EnumBreeSerif.
        /// </summary>
        [EnumMember(Value = "Bree Serif")]
        EnumBreeSerif,

        /// <summary>
        /// EnumBubblegumSans.
        /// </summary>
        [EnumMember(Value = "Bubblegum Sans")]
        EnumBubblegumSans,

        /// <summary>
        /// EnumBubblerOne.
        /// </summary>
        [EnumMember(Value = "Bubbler One")]
        EnumBubblerOne,

        /// <summary>
        /// Buda.
        /// </summary>
        [EnumMember(Value = "Buda")]
        Buda,

        /// <summary>
        /// Buenard.
        /// </summary>
        [EnumMember(Value = "Buenard")]
        Buenard,

        /// <summary>
        /// Bungee.
        /// </summary>
        [EnumMember(Value = "Bungee")]
        Bungee,

        /// <summary>
        /// EnumBungeeHairline.
        /// </summary>
        [EnumMember(Value = "Bungee Hairline")]
        EnumBungeeHairline,

        /// <summary>
        /// EnumBungeeInline.
        /// </summary>
        [EnumMember(Value = "Bungee Inline")]
        EnumBungeeInline,

        /// <summary>
        /// EnumBungeeOutline.
        /// </summary>
        [EnumMember(Value = "Bungee Outline")]
        EnumBungeeOutline,

        /// <summary>
        /// EnumBungeeShade.
        /// </summary>
        [EnumMember(Value = "Bungee Shade")]
        EnumBungeeShade,

        /// <summary>
        /// Butcherman.
        /// </summary>
        [EnumMember(Value = "Butcherman")]
        Butcherman,

        /// <summary>
        /// EnumButterflyKids.
        /// </summary>
        [EnumMember(Value = "Butterfly Kids")]
        EnumButterflyKids,

        /// <summary>
        /// Cabin.
        /// </summary>
        [EnumMember(Value = "Cabin")]
        Cabin,

        /// <summary>
        /// EnumCabinCondensed.
        /// </summary>
        [EnumMember(Value = "Cabin Condensed")]
        EnumCabinCondensed,

        /// <summary>
        /// EnumCabinSketch.
        /// </summary>
        [EnumMember(Value = "Cabin Sketch")]
        EnumCabinSketch,

        /// <summary>
        /// EnumCaesarDressing.
        /// </summary>
        [EnumMember(Value = "Caesar Dressing")]
        EnumCaesarDressing,

        /// <summary>
        /// Cagliostro.
        /// </summary>
        [EnumMember(Value = "Cagliostro")]
        Cagliostro,

        /// <summary>
        /// Cairo.
        /// </summary>
        [EnumMember(Value = "Cairo")]
        Cairo,

        /// <summary>
        /// Calligraffitti.
        /// </summary>
        [EnumMember(Value = "Calligraffitti")]
        Calligraffitti,

        /// <summary>
        /// Cambay.
        /// </summary>
        [EnumMember(Value = "Cambay")]
        Cambay,

        /// <summary>
        /// Cambo.
        /// </summary>
        [EnumMember(Value = "Cambo")]
        Cambo,

        /// <summary>
        /// Candal.
        /// </summary>
        [EnumMember(Value = "Candal")]
        Candal,

        /// <summary>
        /// Cantarell.
        /// </summary>
        [EnumMember(Value = "Cantarell")]
        Cantarell,

        /// <summary>
        /// EnumCantataOne.
        /// </summary>
        [EnumMember(Value = "Cantata One")]
        EnumCantataOne,

        /// <summary>
        /// EnumCantoraOne.
        /// </summary>
        [EnumMember(Value = "Cantora One")]
        EnumCantoraOne,

        /// <summary>
        /// Capriola.
        /// </summary>
        [EnumMember(Value = "Capriola")]
        Capriola,

        /// <summary>
        /// Cardo.
        /// </summary>
        [EnumMember(Value = "Cardo")]
        Cardo,

        /// <summary>
        /// Carme.
        /// </summary>
        [EnumMember(Value = "Carme")]
        Carme,

        /// <summary>
        /// EnumCarroisGothic.
        /// </summary>
        [EnumMember(Value = "Carrois Gothic")]
        EnumCarroisGothic,

        /// <summary>
        /// EnumCarroisGothicSC.
        /// </summary>
        [EnumMember(Value = "Carrois Gothic SC")]
        EnumCarroisGothicSC,

        /// <summary>
        /// EnumCarterOne.
        /// </summary>
        [EnumMember(Value = "Carter One")]
        EnumCarterOne,

        /// <summary>
        /// Catamaran.
        /// </summary>
        [EnumMember(Value = "Catamaran")]
        Catamaran,

        /// <summary>
        /// Caudex.
        /// </summary>
        [EnumMember(Value = "Caudex")]
        Caudex,

        /// <summary>
        /// Caveat.
        /// </summary>
        [EnumMember(Value = "Caveat")]
        Caveat,

        /// <summary>
        /// EnumCaveatBrush.
        /// </summary>
        [EnumMember(Value = "Caveat Brush")]
        EnumCaveatBrush,

        /// <summary>
        /// EnumCedarvilleCursive.
        /// </summary>
        [EnumMember(Value = "Cedarville Cursive")]
        EnumCedarvilleCursive,

        /// <summary>
        /// EnumCevicheOne.
        /// </summary>
        [EnumMember(Value = "Ceviche One")]
        EnumCevicheOne,

        /// <summary>
        /// EnumChakraPetch.
        /// </summary>
        [EnumMember(Value = "Chakra Petch")]
        EnumChakraPetch,

        /// <summary>
        /// Changa.
        /// </summary>
        [EnumMember(Value = "Changa")]
        Changa,

        /// <summary>
        /// EnumChangaOne.
        /// </summary>
        [EnumMember(Value = "Changa One")]
        EnumChangaOne,

        /// <summary>
        /// Chango.
        /// </summary>
        [EnumMember(Value = "Chango")]
        Chango,

        /// <summary>
        /// Charm.
        /// </summary>
        [EnumMember(Value = "Charm")]
        Charm,

        /// <summary>
        /// Charmonman.
        /// </summary>
        [EnumMember(Value = "Charmonman")]
        Charmonman,

        /// <summary>
        /// Chathura.
        /// </summary>
        [EnumMember(Value = "Chathura")]
        Chathura,

        /// <summary>
        /// EnumChauPhilomeneOne.
        /// </summary>
        [EnumMember(Value = "Chau Philomene One")]
        EnumChauPhilomeneOne,

        /// <summary>
        /// EnumChelaOne.
        /// </summary>
        [EnumMember(Value = "Chela One")]
        EnumChelaOne,

        /// <summary>
        /// EnumChelseaMarket.
        /// </summary>
        [EnumMember(Value = "Chelsea Market")]
        EnumChelseaMarket,

        /// <summary>
        /// Chenla.
        /// </summary>
        [EnumMember(Value = "Chenla")]
        Chenla,

        /// <summary>
        /// EnumCherryCreamSoda.
        /// </summary>
        [EnumMember(Value = "Cherry Cream Soda")]
        EnumCherryCreamSoda,

        /// <summary>
        /// EnumCherrySwash.
        /// </summary>
        [EnumMember(Value = "Cherry Swash")]
        EnumCherrySwash,

        /// <summary>
        /// Chewy.
        /// </summary>
        [EnumMember(Value = "Chewy")]
        Chewy,

        /// <summary>
        /// Chicle.
        /// </summary>
        [EnumMember(Value = "Chicle")]
        Chicle,

        /// <summary>
        /// Chilanka.
        /// </summary>
        [EnumMember(Value = "Chilanka")]
        Chilanka,

        /// <summary>
        /// Chivo.
        /// </summary>
        [EnumMember(Value = "Chivo")]
        Chivo,

        /// <summary>
        /// Chonburi.
        /// </summary>
        [EnumMember(Value = "Chonburi")]
        Chonburi,

        /// <summary>
        /// Cinzel.
        /// </summary>
        [EnumMember(Value = "Cinzel")]
        Cinzel,

        /// <summary>
        /// EnumCinzelDecorative.
        /// </summary>
        [EnumMember(Value = "Cinzel Decorative")]
        EnumCinzelDecorative,

        /// <summary>
        /// EnumClickerScript.
        /// </summary>
        [EnumMember(Value = "Clicker Script")]
        EnumClickerScript,

        /// <summary>
        /// Coda.
        /// </summary>
        [EnumMember(Value = "Coda")]
        Coda,

        /// <summary>
        /// EnumCodaCaption.
        /// </summary>
        [EnumMember(Value = "Coda Caption")]
        EnumCodaCaption,

        /// <summary>
        /// Codystar.
        /// </summary>
        [EnumMember(Value = "Codystar")]
        Codystar,

        /// <summary>
        /// Coiny.
        /// </summary>
        [EnumMember(Value = "Coiny")]
        Coiny,

        /// <summary>
        /// Combo.
        /// </summary>
        [EnumMember(Value = "Combo")]
        Combo,

        /// <summary>
        /// Comfortaa.
        /// </summary>
        [EnumMember(Value = "Comfortaa")]
        Comfortaa,

        /// <summary>
        /// EnumComingSoon.
        /// </summary>
        [EnumMember(Value = "Coming Soon")]
        EnumComingSoon,

        /// <summary>
        /// EnumConcertOne.
        /// </summary>
        [EnumMember(Value = "Concert One")]
        EnumConcertOne,

        /// <summary>
        /// Condiment.
        /// </summary>
        [EnumMember(Value = "Condiment")]
        Condiment,

        /// <summary>
        /// Content.
        /// </summary>
        [EnumMember(Value = "Content")]
        Content,

        /// <summary>
        /// EnumContrailOne.
        /// </summary>
        [EnumMember(Value = "Contrail One")]
        EnumContrailOne,

        /// <summary>
        /// Convergence.
        /// </summary>
        [EnumMember(Value = "Convergence")]
        Convergence,

        /// <summary>
        /// Cookie.
        /// </summary>
        [EnumMember(Value = "Cookie")]
        Cookie,

        /// <summary>
        /// Copse.
        /// </summary>
        [EnumMember(Value = "Copse")]
        Copse,

        /// <summary>
        /// Corben.
        /// </summary>
        [EnumMember(Value = "Corben")]
        Corben,

        /// <summary>
        /// Cormorant.
        /// </summary>
        [EnumMember(Value = "Cormorant")]
        Cormorant,

        /// <summary>
        /// EnumCormorantGaramond.
        /// </summary>
        [EnumMember(Value = "Cormorant Garamond")]
        EnumCormorantGaramond,

        /// <summary>
        /// EnumCormorantInfant.
        /// </summary>
        [EnumMember(Value = "Cormorant Infant")]
        EnumCormorantInfant,

        /// <summary>
        /// EnumCormorantSC.
        /// </summary>
        [EnumMember(Value = "Cormorant SC")]
        EnumCormorantSC,

        /// <summary>
        /// EnumCormorantUnicase.
        /// </summary>
        [EnumMember(Value = "Cormorant Unicase")]
        EnumCormorantUnicase,

        /// <summary>
        /// EnumCormorantUpright.
        /// </summary>
        [EnumMember(Value = "Cormorant Upright")]
        EnumCormorantUpright,

        /// <summary>
        /// Courgette.
        /// </summary>
        [EnumMember(Value = "Courgette")]
        Courgette,

        /// <summary>
        /// Cousine.
        /// </summary>
        [EnumMember(Value = "Cousine")]
        Cousine,

        /// <summary>
        /// Coustard.
        /// </summary>
        [EnumMember(Value = "Coustard")]
        Coustard,

        /// <summary>
        /// EnumCoveredByYourGrace.
        /// </summary>
        [EnumMember(Value = "Covered By Your Grace")]
        EnumCoveredByYourGrace,

        /// <summary>
        /// EnumCraftyGirls.
        /// </summary>
        [EnumMember(Value = "Crafty Girls")]
        EnumCraftyGirls,

        /// <summary>
        /// Creepster.
        /// </summary>
        [EnumMember(Value = "Creepster")]
        Creepster,

        /// <summary>
        /// EnumCreteRound.
        /// </summary>
        [EnumMember(Value = "Crete Round")]
        EnumCreteRound,

        /// <summary>
        /// EnumCrimsonPro.
        /// </summary>
        [EnumMember(Value = "Crimson Pro")]
        EnumCrimsonPro,

        /// <summary>
        /// EnumCrimsonText.
        /// </summary>
        [EnumMember(Value = "Crimson Text")]
        EnumCrimsonText,

        /// <summary>
        /// EnumCroissantOne.
        /// </summary>
        [EnumMember(Value = "Croissant One")]
        EnumCroissantOne,

        /// <summary>
        /// Crushed.
        /// </summary>
        [EnumMember(Value = "Crushed")]
        Crushed,

        /// <summary>
        /// Cuprum.
        /// </summary>
        [EnumMember(Value = "Cuprum")]
        Cuprum,

        /// <summary>
        /// EnumCuteFont.
        /// </summary>
        [EnumMember(Value = "Cute Font")]
        EnumCuteFont,

        /// <summary>
        /// Cutive.
        /// </summary>
        [EnumMember(Value = "Cutive")]
        Cutive,

        /// <summary>
        /// EnumCutiveMono.
        /// </summary>
        [EnumMember(Value = "Cutive Mono")]
        EnumCutiveMono,

        /// <summary>
        /// EnumDMSans.
        /// </summary>
        [EnumMember(Value = "DM Sans")]
        EnumDMSans,

        /// <summary>
        /// EnumDMSerifDisplay.
        /// </summary>
        [EnumMember(Value = "DM Serif Display")]
        EnumDMSerifDisplay,

        /// <summary>
        /// EnumDMSerifText.
        /// </summary>
        [EnumMember(Value = "DM Serif Text")]
        EnumDMSerifText,

        /// <summary>
        /// Damion.
        /// </summary>
        [EnumMember(Value = "Damion")]
        Damion,

        /// <summary>
        /// EnumDancingScript.
        /// </summary>
        [EnumMember(Value = "Dancing Script")]
        EnumDancingScript,

        /// <summary>
        /// Dangrek.
        /// </summary>
        [EnumMember(Value = "Dangrek")]
        Dangrek,

        /// <summary>
        /// EnumDarkerGrotesque.
        /// </summary>
        [EnumMember(Value = "Darker Grotesque")]
        EnumDarkerGrotesque,

        /// <summary>
        /// EnumDavidLibre.
        /// </summary>
        [EnumMember(Value = "David Libre")]
        EnumDavidLibre,

        /// <summary>
        /// EnumDawningOfANewDay.
        /// </summary>
        [EnumMember(Value = "Dawning of a New Day")]
        EnumDawningOfANewDay,

        /// <summary>
        /// EnumDaysOne.
        /// </summary>
        [EnumMember(Value = "Days One")]
        EnumDaysOne,

        /// <summary>
        /// Dekko.
        /// </summary>
        [EnumMember(Value = "Dekko")]
        Dekko,

        /// <summary>
        /// Delius.
        /// </summary>
        [EnumMember(Value = "Delius")]
        Delius,

        /// <summary>
        /// EnumDeliusSwashCaps.
        /// </summary>
        [EnumMember(Value = "Delius Swash Caps")]
        EnumDeliusSwashCaps,

        /// <summary>
        /// EnumDeliusUnicase.
        /// </summary>
        [EnumMember(Value = "Delius Unicase")]
        EnumDeliusUnicase,

        /// <summary>
        /// EnumDellaRespira.
        /// </summary>
        [EnumMember(Value = "Della Respira")]
        EnumDellaRespira,

        /// <summary>
        /// EnumDenkOne.
        /// </summary>
        [EnumMember(Value = "Denk One")]
        EnumDenkOne,

        /// <summary>
        /// Devonshire.
        /// </summary>
        [EnumMember(Value = "Devonshire")]
        Devonshire,

        /// <summary>
        /// Dhurjati.
        /// </summary>
        [EnumMember(Value = "Dhurjati")]
        Dhurjati,

        /// <summary>
        /// EnumDidactGothic.
        /// </summary>
        [EnumMember(Value = "Didact Gothic")]
        EnumDidactGothic,

        /// <summary>
        /// Diplomata.
        /// </summary>
        [EnumMember(Value = "Diplomata")]
        Diplomata,

        /// <summary>
        /// EnumDiplomataSC.
        /// </summary>
        [EnumMember(Value = "Diplomata SC")]
        EnumDiplomataSC,

        /// <summary>
        /// EnumDoHyeon.
        /// </summary>
        [EnumMember(Value = "Do Hyeon")]
        EnumDoHyeon,

        /// <summary>
        /// Dokdo.
        /// </summary>
        [EnumMember(Value = "Dokdo")]
        Dokdo,

        /// <summary>
        /// Domine.
        /// </summary>
        [EnumMember(Value = "Domine")]
        Domine,

        /// <summary>
        /// EnumDonegalOne.
        /// </summary>
        [EnumMember(Value = "Donegal One")]
        EnumDonegalOne,

        /// <summary>
        /// EnumDoppioOne.
        /// </summary>
        [EnumMember(Value = "Doppio One")]
        EnumDoppioOne,

        /// <summary>
        /// Dorsa.
        /// </summary>
        [EnumMember(Value = "Dorsa")]
        Dorsa,

        /// <summary>
        /// Dosis.
        /// </summary>
        [EnumMember(Value = "Dosis")]
        Dosis,

        /// <summary>
        /// EnumDrSugiyama.
        /// </summary>
        [EnumMember(Value = "Dr Sugiyama")]
        EnumDrSugiyama,

        /// <summary>
        /// EnumDuruSans.
        /// </summary>
        [EnumMember(Value = "Duru Sans")]
        EnumDuruSans,

        /// <summary>
        /// Dynalight.
        /// </summary>
        [EnumMember(Value = "Dynalight")]
        Dynalight,

        /// <summary>
        /// EnumEBGaramond.
        /// </summary>
        [EnumMember(Value = "EB Garamond")]
        EnumEBGaramond,

        /// <summary>
        /// EnumEagleLake.
        /// </summary>
        [EnumMember(Value = "Eagle Lake")]
        EnumEagleLake,

        /// <summary>
        /// EnumEastSeaDokdo.
        /// </summary>
        [EnumMember(Value = "East Sea Dokdo")]
        EnumEastSeaDokdo,

        /// <summary>
        /// Eater.
        /// </summary>
        [EnumMember(Value = "Eater")]
        Eater,

        /// <summary>
        /// Economica.
        /// </summary>
        [EnumMember(Value = "Economica")]
        Economica,

        /// <summary>
        /// Eczar.
        /// </summary>
        [EnumMember(Value = "Eczar")]
        Eczar,

        /// <summary>
        /// EnumElMessiri.
        /// </summary>
        [EnumMember(Value = "El Messiri")]
        EnumElMessiri,

        /// <summary>
        /// Electrolize.
        /// </summary>
        [EnumMember(Value = "Electrolize")]
        Electrolize,

        /// <summary>
        /// Elsie.
        /// </summary>
        [EnumMember(Value = "Elsie")]
        Elsie,

        /// <summary>
        /// EnumElsieSwashCaps.
        /// </summary>
        [EnumMember(Value = "Elsie Swash Caps")]
        EnumElsieSwashCaps,

        /// <summary>
        /// EnumEmblemaOne.
        /// </summary>
        [EnumMember(Value = "Emblema One")]
        EnumEmblemaOne,

        /// <summary>
        /// EnumEmilysCandy.
        /// </summary>
        [EnumMember(Value = "Emilys Candy")]
        EnumEmilysCandy,

        /// <summary>
        /// EnumEncodeSans.
        /// </summary>
        [EnumMember(Value = "Encode Sans")]
        EnumEncodeSans,

        /// <summary>
        /// EnumEncodeSansCondensed.
        /// </summary>
        [EnumMember(Value = "Encode Sans Condensed")]
        EnumEncodeSansCondensed,

        /// <summary>
        /// EnumEncodeSansExpanded.
        /// </summary>
        [EnumMember(Value = "Encode Sans Expanded")]
        EnumEncodeSansExpanded,

        /// <summary>
        /// EnumEncodeSansSemiCondensed.
        /// </summary>
        [EnumMember(Value = "Encode Sans Semi Condensed")]
        EnumEncodeSansSemiCondensed,

        /// <summary>
        /// EnumEncodeSansSemiExpanded.
        /// </summary>
        [EnumMember(Value = "Encode Sans Semi Expanded")]
        EnumEncodeSansSemiExpanded,

        /// <summary>
        /// Engagement.
        /// </summary>
        [EnumMember(Value = "Engagement")]
        Engagement,

        /// <summary>
        /// Englebert.
        /// </summary>
        [EnumMember(Value = "Englebert")]
        Englebert,

        /// <summary>
        /// Enriqueta.
        /// </summary>
        [EnumMember(Value = "Enriqueta")]
        Enriqueta,

        /// <summary>
        /// EnumEricaOne.
        /// </summary>
        [EnumMember(Value = "Erica One")]
        EnumEricaOne,

        /// <summary>
        /// Esteban.
        /// </summary>
        [EnumMember(Value = "Esteban")]
        Esteban,

        /// <summary>
        /// EnumEuphoriaScript.
        /// </summary>
        [EnumMember(Value = "Euphoria Script")]
        EnumEuphoriaScript,

        /// <summary>
        /// Ewert.
        /// </summary>
        [EnumMember(Value = "Ewert")]
        Ewert,

        /// <summary>
        /// Exo.
        /// </summary>
        [EnumMember(Value = "Exo")]
        Exo,

        /// <summary>
        /// EnumExo2.
        /// </summary>
        [EnumMember(Value = "Exo 2")]
        EnumExo2,

        /// <summary>
        /// EnumExpletusSans.
        /// </summary>
        [EnumMember(Value = "Expletus Sans")]
        EnumExpletusSans,

        /// <summary>
        /// Fahkwang.
        /// </summary>
        [EnumMember(Value = "Fahkwang")]
        Fahkwang,

        /// <summary>
        /// EnumFanwoodText.
        /// </summary>
        [EnumMember(Value = "Fanwood Text")]
        EnumFanwoodText,

        /// <summary>
        /// Farro.
        /// </summary>
        [EnumMember(Value = "Farro")]
        Farro,

        /// <summary>
        /// Farsan.
        /// </summary>
        [EnumMember(Value = "Farsan")]
        Farsan,

        /// <summary>
        /// Fascinate.
        /// </summary>
        [EnumMember(Value = "Fascinate")]
        Fascinate,

        /// <summary>
        /// EnumFascinateInline.
        /// </summary>
        [EnumMember(Value = "Fascinate Inline")]
        EnumFascinateInline,

        /// <summary>
        /// EnumFasterOne.
        /// </summary>
        [EnumMember(Value = "Faster One")]
        EnumFasterOne,

        /// <summary>
        /// Fasthand.
        /// </summary>
        [EnumMember(Value = "Fasthand")]
        Fasthand,

        /// <summary>
        /// EnumFaunaOne.
        /// </summary>
        [EnumMember(Value = "Fauna One")]
        EnumFaunaOne,

        /// <summary>
        /// Faustina.
        /// </summary>
        [EnumMember(Value = "Faustina")]
        Faustina,

        /// <summary>
        /// Federant.
        /// </summary>
        [EnumMember(Value = "Federant")]
        Federant,

        /// <summary>
        /// Federo.
        /// </summary>
        [EnumMember(Value = "Federo")]
        Federo,

        /// <summary>
        /// Felipa.
        /// </summary>
        [EnumMember(Value = "Felipa")]
        Felipa,

        /// <summary>
        /// Fenix.
        /// </summary>
        [EnumMember(Value = "Fenix")]
        Fenix,

        /// <summary>
        /// EnumFingerPaint.
        /// </summary>
        [EnumMember(Value = "Finger Paint")]
        EnumFingerPaint,

        /// <summary>
        /// EnumFiraCode.
        /// </summary>
        [EnumMember(Value = "Fira Code")]
        EnumFiraCode,

        /// <summary>
        /// EnumFiraMono.
        /// </summary>
        [EnumMember(Value = "Fira Mono")]
        EnumFiraMono,

        /// <summary>
        /// EnumFiraSans.
        /// </summary>
        [EnumMember(Value = "Fira Sans")]
        EnumFiraSans,

        /// <summary>
        /// EnumFiraSansCondensed.
        /// </summary>
        [EnumMember(Value = "Fira Sans Condensed")]
        EnumFiraSansCondensed,

        /// <summary>
        /// EnumFiraSansExtraCondensed.
        /// </summary>
        [EnumMember(Value = "Fira Sans Extra Condensed")]
        EnumFiraSansExtraCondensed,

        /// <summary>
        /// EnumFjallaOne.
        /// </summary>
        [EnumMember(Value = "Fjalla One")]
        EnumFjallaOne,

        /// <summary>
        /// EnumFjordOne.
        /// </summary>
        [EnumMember(Value = "Fjord One")]
        EnumFjordOne,

        /// <summary>
        /// Flamenco.
        /// </summary>
        [EnumMember(Value = "Flamenco")]
        Flamenco,

        /// <summary>
        /// Flavors.
        /// </summary>
        [EnumMember(Value = "Flavors")]
        Flavors,

        /// <summary>
        /// Fondamento.
        /// </summary>
        [EnumMember(Value = "Fondamento")]
        Fondamento,

        /// <summary>
        /// EnumFontdinerSwanky.
        /// </summary>
        [EnumMember(Value = "Fontdiner Swanky")]
        EnumFontdinerSwanky,

        /// <summary>
        /// Forum.
        /// </summary>
        [EnumMember(Value = "Forum")]
        Forum,

        /// <summary>
        /// EnumFrancoisOne.
        /// </summary>
        [EnumMember(Value = "Francois One")]
        EnumFrancoisOne,

        /// <summary>
        /// EnumFrankRuhlLibre.
        /// </summary>
        [EnumMember(Value = "Frank Ruhl Libre")]
        EnumFrankRuhlLibre,

        /// <summary>
        /// EnumFreckleFace.
        /// </summary>
        [EnumMember(Value = "Freckle Face")]
        EnumFreckleFace,

        /// <summary>
        /// EnumFrederickaTheGreat.
        /// </summary>
        [EnumMember(Value = "Fredericka the Great")]
        EnumFrederickaTheGreat,

        /// <summary>
        /// EnumFredokaOne.
        /// </summary>
        [EnumMember(Value = "Fredoka One")]
        EnumFredokaOne,

        /// <summary>
        /// Freehand.
        /// </summary>
        [EnumMember(Value = "Freehand")]
        Freehand,

        /// <summary>
        /// Fresca.
        /// </summary>
        [EnumMember(Value = "Fresca")]
        Fresca,

        /// <summary>
        /// Frijole.
        /// </summary>
        [EnumMember(Value = "Frijole")]
        Frijole,

        /// <summary>
        /// Fruktur.
        /// </summary>
        [EnumMember(Value = "Fruktur")]
        Fruktur,

        /// <summary>
        /// EnumFugazOne.
        /// </summary>
        [EnumMember(Value = "Fugaz One")]
        EnumFugazOne,

        /// <summary>
        /// EnumGFSDidot.
        /// </summary>
        [EnumMember(Value = "GFS Didot")]
        EnumGFSDidot,

        /// <summary>
        /// EnumGFSNeohellenic.
        /// </summary>
        [EnumMember(Value = "GFS Neohellenic")]
        EnumGFSNeohellenic,

        /// <summary>
        /// Gabriela.
        /// </summary>
        [EnumMember(Value = "Gabriela")]
        Gabriela,

        /// <summary>
        /// Gaegu.
        /// </summary>
        [EnumMember(Value = "Gaegu")]
        Gaegu,

        /// <summary>
        /// Gafata.
        /// </summary>
        [EnumMember(Value = "Gafata")]
        Gafata,

        /// <summary>
        /// Galada.
        /// </summary>
        [EnumMember(Value = "Galada")]
        Galada,

        /// <summary>
        /// Galdeano.
        /// </summary>
        [EnumMember(Value = "Galdeano")]
        Galdeano,

        /// <summary>
        /// Galindo.
        /// </summary>
        [EnumMember(Value = "Galindo")]
        Galindo,

        /// <summary>
        /// EnumGamjaFlower.
        /// </summary>
        [EnumMember(Value = "Gamja Flower")]
        EnumGamjaFlower,

        /// <summary>
        /// Gayathri.
        /// </summary>
        [EnumMember(Value = "Gayathri")]
        Gayathri,

        /// <summary>
        /// EnumGentiumBasic.
        /// </summary>
        [EnumMember(Value = "Gentium Basic")]
        EnumGentiumBasic,

        /// <summary>
        /// EnumGentiumBookBasic.
        /// </summary>
        [EnumMember(Value = "Gentium Book Basic")]
        EnumGentiumBookBasic,

        /// <summary>
        /// Geo.
        /// </summary>
        [EnumMember(Value = "Geo")]
        Geo,

        /// <summary>
        /// Geostar.
        /// </summary>
        [EnumMember(Value = "Geostar")]
        Geostar,

        /// <summary>
        /// EnumGeostarFill.
        /// </summary>
        [EnumMember(Value = "Geostar Fill")]
        EnumGeostarFill,

        /// <summary>
        /// EnumGermaniaOne.
        /// </summary>
        [EnumMember(Value = "Germania One")]
        EnumGermaniaOne,

        /// <summary>
        /// Gidugu.
        /// </summary>
        [EnumMember(Value = "Gidugu")]
        Gidugu,

        /// <summary>
        /// EnumGildaDisplay.
        /// </summary>
        [EnumMember(Value = "Gilda Display")]
        EnumGildaDisplay,

        /// <summary>
        /// EnumGiveYouGlory.
        /// </summary>
        [EnumMember(Value = "Give You Glory")]
        EnumGiveYouGlory,

        /// <summary>
        /// EnumGlassAntiqua.
        /// </summary>
        [EnumMember(Value = "Glass Antiqua")]
        EnumGlassAntiqua,

        /// <summary>
        /// Glegoo.
        /// </summary>
        [EnumMember(Value = "Glegoo")]
        Glegoo,

        /// <summary>
        /// EnumGloriaHallelujah.
        /// </summary>
        [EnumMember(Value = "Gloria Hallelujah")]
        EnumGloriaHallelujah,

        /// <summary>
        /// EnumGoblinOne.
        /// </summary>
        [EnumMember(Value = "Goblin One")]
        EnumGoblinOne,

        /// <summary>
        /// EnumGochiHand.
        /// </summary>
        [EnumMember(Value = "Gochi Hand")]
        EnumGochiHand,

        /// <summary>
        /// Gorditas.
        /// </summary>
        [EnumMember(Value = "Gorditas")]
        Gorditas,

        /// <summary>
        /// EnumGothicA1.
        /// </summary>
        [EnumMember(Value = "Gothic A1")]
        EnumGothicA1,

        /// <summary>
        /// EnumGoudyBookletter1911.
        /// </summary>
        [EnumMember(Value = "Goudy Bookletter 1911")]
        EnumGoudyBookletter1911,

        /// <summary>
        /// Graduate.
        /// </summary>
        [EnumMember(Value = "Graduate")]
        Graduate,

        /// <summary>
        /// EnumGrandHotel.
        /// </summary>
        [EnumMember(Value = "Grand Hotel")]
        EnumGrandHotel,

        /// <summary>
        /// EnumGravitasOne.
        /// </summary>
        [EnumMember(Value = "Gravitas One")]
        EnumGravitasOne,

        /// <summary>
        /// EnumGreatVibes.
        /// </summary>
        [EnumMember(Value = "Great Vibes")]
        EnumGreatVibes,

        /// <summary>
        /// Grenze.
        /// </summary>
        [EnumMember(Value = "Grenze")]
        Grenze,

        /// <summary>
        /// Griffy.
        /// </summary>
        [EnumMember(Value = "Griffy")]
        Griffy,

        /// <summary>
        /// Gruppo.
        /// </summary>
        [EnumMember(Value = "Gruppo")]
        Gruppo,

        /// <summary>
        /// Gudea.
        /// </summary>
        [EnumMember(Value = "Gudea")]
        Gudea,

        /// <summary>
        /// Gugi.
        /// </summary>
        [EnumMember(Value = "Gugi")]
        Gugi,

        /// <summary>
        /// Gurajada.
        /// </summary>
        [EnumMember(Value = "Gurajada")]
        Gurajada,

        /// <summary>
        /// Habibi.
        /// </summary>
        [EnumMember(Value = "Habibi")]
        Habibi,

        /// <summary>
        /// Halant.
        /// </summary>
        [EnumMember(Value = "Halant")]
        Halant,

        /// <summary>
        /// EnumHammersmithOne.
        /// </summary>
        [EnumMember(Value = "Hammersmith One")]
        EnumHammersmithOne,

        /// <summary>
        /// Hanalei.
        /// </summary>
        [EnumMember(Value = "Hanalei")]
        Hanalei,

        /// <summary>
        /// EnumHanaleiFill.
        /// </summary>
        [EnumMember(Value = "Hanalei Fill")]
        EnumHanaleiFill,

        /// <summary>
        /// Handlee.
        /// </summary>
        [EnumMember(Value = "Handlee")]
        Handlee,

        /// <summary>
        /// Hanuman.
        /// </summary>
        [EnumMember(Value = "Hanuman")]
        Hanuman,

        /// <summary>
        /// EnumHappyMonkey.
        /// </summary>
        [EnumMember(Value = "Happy Monkey")]
        EnumHappyMonkey,

        /// <summary>
        /// Harmattan.
        /// </summary>
        [EnumMember(Value = "Harmattan")]
        Harmattan,

        /// <summary>
        /// EnumHeadlandOne.
        /// </summary>
        [EnumMember(Value = "Headland One")]
        EnumHeadlandOne,

        /// <summary>
        /// Heebo.
        /// </summary>
        [EnumMember(Value = "Heebo")]
        Heebo,

        /// <summary>
        /// EnumHennyPenny.
        /// </summary>
        [EnumMember(Value = "Henny Penny")]
        EnumHennyPenny,

        /// <summary>
        /// EnumHeptaSlab.
        /// </summary>
        [EnumMember(Value = "Hepta Slab")]
        EnumHeptaSlab,

        /// <summary>
        /// EnumHerrVonMuellerhoff.
        /// </summary>
        [EnumMember(Value = "Herr Von Muellerhoff")]
        EnumHerrVonMuellerhoff,

        /// <summary>
        /// EnumHiMelody.
        /// </summary>
        [EnumMember(Value = "Hi Melody")]
        EnumHiMelody,

        /// <summary>
        /// Hind.
        /// </summary>
        [EnumMember(Value = "Hind")]
        Hind,

        /// <summary>
        /// EnumHindGuntur.
        /// </summary>
        [EnumMember(Value = "Hind Guntur")]
        EnumHindGuntur,

        /// <summary>
        /// EnumHindMadurai.
        /// </summary>
        [EnumMember(Value = "Hind Madurai")]
        EnumHindMadurai,

        /// <summary>
        /// EnumHindSiliguri.
        /// </summary>
        [EnumMember(Value = "Hind Siliguri")]
        EnumHindSiliguri,

        /// <summary>
        /// EnumHindVadodara.
        /// </summary>
        [EnumMember(Value = "Hind Vadodara")]
        EnumHindVadodara,

        /// <summary>
        /// EnumHoltwoodOneSC.
        /// </summary>
        [EnumMember(Value = "Holtwood One SC")]
        EnumHoltwoodOneSC,

        /// <summary>
        /// EnumHomemadeApple.
        /// </summary>
        [EnumMember(Value = "Homemade Apple")]
        EnumHomemadeApple,

        /// <summary>
        /// Homenaje.
        /// </summary>
        [EnumMember(Value = "Homenaje")]
        Homenaje,

        /// <summary>
        /// EnumIBMPlexMono.
        /// </summary>
        [EnumMember(Value = "IBM Plex Mono")]
        EnumIBMPlexMono,

        /// <summary>
        /// EnumIBMPlexSans.
        /// </summary>
        [EnumMember(Value = "IBM Plex Sans")]
        EnumIBMPlexSans,

        /// <summary>
        /// EnumIBMPlexSansCondensed.
        /// </summary>
        [EnumMember(Value = "IBM Plex Sans Condensed")]
        EnumIBMPlexSansCondensed,

        /// <summary>
        /// EnumIBMPlexSerif.
        /// </summary>
        [EnumMember(Value = "IBM Plex Serif")]
        EnumIBMPlexSerif,

        /// <summary>
        /// EnumIMFellDWPica.
        /// </summary>
        [EnumMember(Value = "IM Fell DW Pica")]
        EnumIMFellDWPica,

        /// <summary>
        /// EnumIMFellDWPicaSC.
        /// </summary>
        [EnumMember(Value = "IM Fell DW Pica SC")]
        EnumIMFellDWPicaSC,

        /// <summary>
        /// EnumIMFellDoublePica.
        /// </summary>
        [EnumMember(Value = "IM Fell Double Pica")]
        EnumIMFellDoublePica,

        /// <summary>
        /// EnumIMFellDoublePicaSC.
        /// </summary>
        [EnumMember(Value = "IM Fell Double Pica SC")]
        EnumIMFellDoublePicaSC,

        /// <summary>
        /// EnumIMFellEnglish.
        /// </summary>
        [EnumMember(Value = "IM Fell English")]
        EnumIMFellEnglish,

        /// <summary>
        /// EnumIMFellEnglishSC.
        /// </summary>
        [EnumMember(Value = "IM Fell English SC")]
        EnumIMFellEnglishSC,

        /// <summary>
        /// EnumIMFellFrenchCanon.
        /// </summary>
        [EnumMember(Value = "IM Fell French Canon")]
        EnumIMFellFrenchCanon,

        /// <summary>
        /// EnumIMFellFrenchCanonSC.
        /// </summary>
        [EnumMember(Value = "IM Fell French Canon SC")]
        EnumIMFellFrenchCanonSC,

        /// <summary>
        /// EnumIMFellGreatPrimer.
        /// </summary>
        [EnumMember(Value = "IM Fell Great Primer")]
        EnumIMFellGreatPrimer,

        /// <summary>
        /// EnumIMFellGreatPrimerSC.
        /// </summary>
        [EnumMember(Value = "IM Fell Great Primer SC")]
        EnumIMFellGreatPrimerSC,

        /// <summary>
        /// Iceberg.
        /// </summary>
        [EnumMember(Value = "Iceberg")]
        Iceberg,

        /// <summary>
        /// Iceland.
        /// </summary>
        [EnumMember(Value = "Iceland")]
        Iceland,

        /// <summary>
        /// Imprima.
        /// </summary>
        [EnumMember(Value = "Imprima")]
        Imprima,

        /// <summary>
        /// Inconsolata.
        /// </summary>
        [EnumMember(Value = "Inconsolata")]
        Inconsolata,

        /// <summary>
        /// Inder.
        /// </summary>
        [EnumMember(Value = "Inder")]
        Inder,

        /// <summary>
        /// EnumIndieFlower.
        /// </summary>
        [EnumMember(Value = "Indie Flower")]
        EnumIndieFlower,

        /// <summary>
        /// Inika.
        /// </summary>
        [EnumMember(Value = "Inika")]
        Inika,

        /// <summary>
        /// EnumInknutAntiqua.
        /// </summary>
        [EnumMember(Value = "Inknut Antiqua")]
        EnumInknutAntiqua,

        /// <summary>
        /// EnumIrishGrover.
        /// </summary>
        [EnumMember(Value = "Irish Grover")]
        EnumIrishGrover,

        /// <summary>
        /// EnumIstokWeb.
        /// </summary>
        [EnumMember(Value = "Istok Web")]
        EnumIstokWeb,

        /// <summary>
        /// Italiana.
        /// </summary>
        [EnumMember(Value = "Italiana")]
        Italiana,

        /// <summary>
        /// Italianno.
        /// </summary>
        [EnumMember(Value = "Italianno")]
        Italianno,

        /// <summary>
        /// Itim.
        /// </summary>
        [EnumMember(Value = "Itim")]
        Itim,

        /// <summary>
        /// EnumJacquesFrancois.
        /// </summary>
        [EnumMember(Value = "Jacques Francois")]
        EnumJacquesFrancois,

        /// <summary>
        /// EnumJacquesFrancoisShadow.
        /// </summary>
        [EnumMember(Value = "Jacques Francois Shadow")]
        EnumJacquesFrancoisShadow,

        /// <summary>
        /// Jaldi.
        /// </summary>
        [EnumMember(Value = "Jaldi")]
        Jaldi,

        /// <summary>
        /// EnumJimNightshade.
        /// </summary>
        [EnumMember(Value = "Jim Nightshade")]
        EnumJimNightshade,

        /// <summary>
        /// EnumJockeyOne.
        /// </summary>
        [EnumMember(Value = "Jockey One")]
        EnumJockeyOne,

        /// <summary>
        /// EnumJollyLodger.
        /// </summary>
        [EnumMember(Value = "Jolly Lodger")]
        EnumJollyLodger,

        /// <summary>
        /// Jomhuria.
        /// </summary>
        [EnumMember(Value = "Jomhuria")]
        Jomhuria,

        /// <summary>
        /// Jomolhari.
        /// </summary>
        [EnumMember(Value = "Jomolhari")]
        Jomolhari,

        /// <summary>
        /// EnumJosefinSans.
        /// </summary>
        [EnumMember(Value = "Josefin Sans")]
        EnumJosefinSans,

        /// <summary>
        /// EnumJosefinSlab.
        /// </summary>
        [EnumMember(Value = "Josefin Slab")]
        EnumJosefinSlab,

        /// <summary>
        /// EnumJotiOne.
        /// </summary>
        [EnumMember(Value = "Joti One")]
        EnumJotiOne,

        /// <summary>
        /// Jua.
        /// </summary>
        [EnumMember(Value = "Jua")]
        Jua,

        /// <summary>
        /// Judson.
        /// </summary>
        [EnumMember(Value = "Judson")]
        Judson,

        /// <summary>
        /// Julee.
        /// </summary>
        [EnumMember(Value = "Julee")]
        Julee,

        /// <summary>
        /// EnumJuliusSansOne.
        /// </summary>
        [EnumMember(Value = "Julius Sans One")]
        EnumJuliusSansOne,

        /// <summary>
        /// Junge.
        /// </summary>
        [EnumMember(Value = "Junge")]
        Junge,

        /// <summary>
        /// Jura.
        /// </summary>
        [EnumMember(Value = "Jura")]
        Jura,

        /// <summary>
        /// EnumJustAnotherHand.
        /// </summary>
        [EnumMember(Value = "Just Another Hand")]
        EnumJustAnotherHand,

        /// <summary>
        /// EnumJustMeAgainDownHere.
        /// </summary>
        [EnumMember(Value = "Just Me Again Down Here")]
        EnumJustMeAgainDownHere,

        /// <summary>
        /// K2D.
        /// </summary>
        [EnumMember(Value = "K2D")]
        K2D,

        /// <summary>
        /// Kadwa.
        /// </summary>
        [EnumMember(Value = "Kadwa")]
        Kadwa,

        /// <summary>
        /// Kalam.
        /// </summary>
        [EnumMember(Value = "Kalam")]
        Kalam,

        /// <summary>
        /// Kameron.
        /// </summary>
        [EnumMember(Value = "Kameron")]
        Kameron,

        /// <summary>
        /// Kanit.
        /// </summary>
        [EnumMember(Value = "Kanit")]
        Kanit,

        /// <summary>
        /// Kantumruy.
        /// </summary>
        [EnumMember(Value = "Kantumruy")]
        Kantumruy,

        /// <summary>
        /// Karla.
        /// </summary>
        [EnumMember(Value = "Karla")]
        Karla,

        /// <summary>
        /// Karma.
        /// </summary>
        [EnumMember(Value = "Karma")]
        Karma,

        /// <summary>
        /// Katibeh.
        /// </summary>
        [EnumMember(Value = "Katibeh")]
        Katibeh,

        /// <summary>
        /// EnumKaushanScript.
        /// </summary>
        [EnumMember(Value = "Kaushan Script")]
        EnumKaushanScript,

        /// <summary>
        /// Kavivanar.
        /// </summary>
        [EnumMember(Value = "Kavivanar")]
        Kavivanar,

        /// <summary>
        /// Kavoon.
        /// </summary>
        [EnumMember(Value = "Kavoon")]
        Kavoon,

        /// <summary>
        /// EnumKdamThmor.
        /// </summary>
        [EnumMember(Value = "Kdam Thmor")]
        EnumKdamThmor,

        /// <summary>
        /// EnumKeaniaOne.
        /// </summary>
        [EnumMember(Value = "Keania One")]
        EnumKeaniaOne,

        /// <summary>
        /// EnumKellySlab.
        /// </summary>
        [EnumMember(Value = "Kelly Slab")]
        EnumKellySlab,

        /// <summary>
        /// Kenia.
        /// </summary>
        [EnumMember(Value = "Kenia")]
        Kenia,

        /// <summary>
        /// Khand.
        /// </summary>
        [EnumMember(Value = "Khand")]
        Khand,

        /// <summary>
        /// Khmer.
        /// </summary>
        [EnumMember(Value = "Khmer")]
        Khmer,

        /// <summary>
        /// Khula.
        /// </summary>
        [EnumMember(Value = "Khula")]
        Khula,

        /// <summary>
        /// EnumKirangHaerang.
        /// </summary>
        [EnumMember(Value = "Kirang Haerang")]
        EnumKirangHaerang,

        /// <summary>
        /// EnumKiteOne.
        /// </summary>
        [EnumMember(Value = "Kite One")]
        EnumKiteOne,

        /// <summary>
        /// Knewave.
        /// </summary>
        [EnumMember(Value = "Knewave")]
        Knewave,

        /// <summary>
        /// KoHo.
        /// </summary>
        [EnumMember(Value = "KoHo")]
        KoHo,

        /// <summary>
        /// Kodchasan.
        /// </summary>
        [EnumMember(Value = "Kodchasan")]
        Kodchasan,

        /// <summary>
        /// Kosugi.
        /// </summary>
        [EnumMember(Value = "Kosugi")]
        Kosugi,

        /// <summary>
        /// EnumKosugiMaru.
        /// </summary>
        [EnumMember(Value = "Kosugi Maru")]
        EnumKosugiMaru,

        /// <summary>
        /// EnumKottaOne.
        /// </summary>
        [EnumMember(Value = "Kotta One")]
        EnumKottaOne,

        /// <summary>
        /// Koulen.
        /// </summary>
        [EnumMember(Value = "Koulen")]
        Koulen,

        /// <summary>
        /// Kranky.
        /// </summary>
        [EnumMember(Value = "Kranky")]
        Kranky,

        /// <summary>
        /// Kreon.
        /// </summary>
        [EnumMember(Value = "Kreon")]
        Kreon,

        /// <summary>
        /// Kristi.
        /// </summary>
        [EnumMember(Value = "Kristi")]
        Kristi,

        /// <summary>
        /// EnumKronaOne.
        /// </summary>
        [EnumMember(Value = "Krona One")]
        EnumKronaOne,

        /// <summary>
        /// Krub.
        /// </summary>
        [EnumMember(Value = "Krub")]
        Krub,

        /// <summary>
        /// EnumKumarOne.
        /// </summary>
        [EnumMember(Value = "Kumar One")]
        EnumKumarOne,

        /// <summary>
        /// EnumKumarOneOutline.
        /// </summary>
        [EnumMember(Value = "Kumar One Outline")]
        EnumKumarOneOutline,

        /// <summary>
        /// Kurale.
        /// </summary>
        [EnumMember(Value = "Kurale")]
        Kurale,

        /// <summary>
        /// EnumLaBelleAurore.
        /// </summary>
        [EnumMember(Value = "La Belle Aurore")]
        EnumLaBelleAurore,

        /// <summary>
        /// Lacquer.
        /// </summary>
        [EnumMember(Value = "Lacquer")]
        Lacquer,

        /// <summary>
        /// Laila.
        /// </summary>
        [EnumMember(Value = "Laila")]
        Laila,

        /// <summary>
        /// EnumLakkiReddy.
        /// </summary>
        [EnumMember(Value = "Lakki Reddy")]
        EnumLakkiReddy,

        /// <summary>
        /// Lalezar.
        /// </summary>
        [EnumMember(Value = "Lalezar")]
        Lalezar,

        /// <summary>
        /// Lancelot.
        /// </summary>
        [EnumMember(Value = "Lancelot")]
        Lancelot,

        /// <summary>
        /// Lateef.
        /// </summary>
        [EnumMember(Value = "Lateef")]
        Lateef,

        /// <summary>
        /// Lato.
        /// </summary>
        [EnumMember(Value = "Lato")]
        Lato,

        /// <summary>
        /// EnumLeagueScript.
        /// </summary>
        [EnumMember(Value = "League Script")]
        EnumLeagueScript,

        /// <summary>
        /// EnumLeckerliOne.
        /// </summary>
        [EnumMember(Value = "Leckerli One")]
        EnumLeckerliOne,

        /// <summary>
        /// Ledger.
        /// </summary>
        [EnumMember(Value = "Ledger")]
        Ledger,

        /// <summary>
        /// Lekton.
        /// </summary>
        [EnumMember(Value = "Lekton")]
        Lekton,

        /// <summary>
        /// Lemon.
        /// </summary>
        [EnumMember(Value = "Lemon")]
        Lemon,

        /// <summary>
        /// Lemonada.
        /// </summary>
        [EnumMember(Value = "Lemonada")]
        Lemonada,

        /// <summary>
        /// EnumLexendDeca.
        /// </summary>
        [EnumMember(Value = "Lexend Deca")]
        EnumLexendDeca,

        /// <summary>
        /// EnumLexendExa.
        /// </summary>
        [EnumMember(Value = "Lexend Exa")]
        EnumLexendExa,

        /// <summary>
        /// EnumLexendGiga.
        /// </summary>
        [EnumMember(Value = "Lexend Giga")]
        EnumLexendGiga,

        /// <summary>
        /// EnumLexendMega.
        /// </summary>
        [EnumMember(Value = "Lexend Mega")]
        EnumLexendMega,

        /// <summary>
        /// EnumLexendPeta.
        /// </summary>
        [EnumMember(Value = "Lexend Peta")]
        EnumLexendPeta,

        /// <summary>
        /// EnumLexendTera.
        /// </summary>
        [EnumMember(Value = "Lexend Tera")]
        EnumLexendTera,

        /// <summary>
        /// EnumLexendZetta.
        /// </summary>
        [EnumMember(Value = "Lexend Zetta")]
        EnumLexendZetta,

        /// <summary>
        /// EnumLibreBarcode128.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 128")]
        EnumLibreBarcode128,

        /// <summary>
        /// EnumLibreBarcode128Text.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 128 Text")]
        EnumLibreBarcode128Text,

        /// <summary>
        /// EnumLibreBarcode39.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 39")]
        EnumLibreBarcode39,

        /// <summary>
        /// EnumLibreBarcode39Extended.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 39 Extended")]
        EnumLibreBarcode39Extended,

        /// <summary>
        /// EnumLibreBarcode39ExtendedText.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 39 Extended Text")]
        EnumLibreBarcode39ExtendedText,

        /// <summary>
        /// EnumLibreBarcode39Text.
        /// </summary>
        [EnumMember(Value = "Libre Barcode 39 Text")]
        EnumLibreBarcode39Text,

        /// <summary>
        /// EnumLibreBaskerville.
        /// </summary>
        [EnumMember(Value = "Libre Baskerville")]
        EnumLibreBaskerville,

        /// <summary>
        /// EnumLibreCaslonDisplay.
        /// </summary>
        [EnumMember(Value = "Libre Caslon Display")]
        EnumLibreCaslonDisplay,

        /// <summary>
        /// EnumLibreCaslonText.
        /// </summary>
        [EnumMember(Value = "Libre Caslon Text")]
        EnumLibreCaslonText,

        /// <summary>
        /// EnumLibreFranklin.
        /// </summary>
        [EnumMember(Value = "Libre Franklin")]
        EnumLibreFranklin,

        /// <summary>
        /// EnumLifeSavers.
        /// </summary>
        [EnumMember(Value = "Life Savers")]
        EnumLifeSavers,

        /// <summary>
        /// EnumLilitaOne.
        /// </summary>
        [EnumMember(Value = "Lilita One")]
        EnumLilitaOne,

        /// <summary>
        /// EnumLilyScriptOne.
        /// </summary>
        [EnumMember(Value = "Lily Script One")]
        EnumLilyScriptOne,

        /// <summary>
        /// Limelight.
        /// </summary>
        [EnumMember(Value = "Limelight")]
        Limelight,

        /// <summary>
        /// EnumLindenHill.
        /// </summary>
        [EnumMember(Value = "Linden Hill")]
        EnumLindenHill,

        /// <summary>
        /// Literata.
        /// </summary>
        [EnumMember(Value = "Literata")]
        Literata,

        /// <summary>
        /// EnumLiuJianMaoCao.
        /// </summary>
        [EnumMember(Value = "Liu Jian Mao Cao")]
        EnumLiuJianMaoCao,

        /// <summary>
        /// Livvic.
        /// </summary>
        [EnumMember(Value = "Livvic")]
        Livvic,

        /// <summary>
        /// Lobster.
        /// </summary>
        [EnumMember(Value = "Lobster")]
        Lobster,

        /// <summary>
        /// EnumLobsterTwo.
        /// </summary>
        [EnumMember(Value = "Lobster Two")]
        EnumLobsterTwo,

        /// <summary>
        /// EnumLondrinaOutline.
        /// </summary>
        [EnumMember(Value = "Londrina Outline")]
        EnumLondrinaOutline,

        /// <summary>
        /// EnumLondrinaShadow.
        /// </summary>
        [EnumMember(Value = "Londrina Shadow")]
        EnumLondrinaShadow,

        /// <summary>
        /// EnumLondrinaSketch.
        /// </summary>
        [EnumMember(Value = "Londrina Sketch")]
        EnumLondrinaSketch,

        /// <summary>
        /// EnumLondrinaSolid.
        /// </summary>
        [EnumMember(Value = "Londrina Solid")]
        EnumLondrinaSolid,

        /// <summary>
        /// EnumLongCang.
        /// </summary>
        [EnumMember(Value = "Long Cang")]
        EnumLongCang,

        /// <summary>
        /// Lora.
        /// </summary>
        [EnumMember(Value = "Lora")]
        Lora,

        /// <summary>
        /// EnumLoveYaLikeASister.
        /// </summary>
        [EnumMember(Value = "Love Ya Like A Sister")]
        EnumLoveYaLikeASister,

        /// <summary>
        /// EnumLovedByTheKing.
        /// </summary>
        [EnumMember(Value = "Loved by the King")]
        EnumLovedByTheKing,

        /// <summary>
        /// EnumLoversQuarrel.
        /// </summary>
        [EnumMember(Value = "Lovers Quarrel")]
        EnumLoversQuarrel,

        /// <summary>
        /// EnumLuckiestGuy.
        /// </summary>
        [EnumMember(Value = "Luckiest Guy")]
        EnumLuckiestGuy,

        /// <summary>
        /// Lusitana.
        /// </summary>
        [EnumMember(Value = "Lusitana")]
        Lusitana,

        /// <summary>
        /// Lustria.
        /// </summary>
        [EnumMember(Value = "Lustria")]
        Lustria,

        /// <summary>
        /// EnumMPLUS1p.
        /// </summary>
        [EnumMember(Value = "M PLUS 1p")]
        EnumMPLUS1p,

        /// <summary>
        /// EnumMPLUSRounded1c.
        /// </summary>
        [EnumMember(Value = "M PLUS Rounded 1c")]
        EnumMPLUSRounded1c,

        /// <summary>
        /// EnumMaShanZheng.
        /// </summary>
        [EnumMember(Value = "Ma Shan Zheng")]
        EnumMaShanZheng,

        /// <summary>
        /// Macondo.
        /// </summary>
        [EnumMember(Value = "Macondo")]
        Macondo,

        /// <summary>
        /// EnumMacondoSwashCaps.
        /// </summary>
        [EnumMember(Value = "Macondo Swash Caps")]
        EnumMacondoSwashCaps,

        /// <summary>
        /// Mada.
        /// </summary>
        [EnumMember(Value = "Mada")]
        Mada,

        /// <summary>
        /// Magra.
        /// </summary>
        [EnumMember(Value = "Magra")]
        Magra,

        /// <summary>
        /// EnumMaidenOrange.
        /// </summary>
        [EnumMember(Value = "Maiden Orange")]
        EnumMaidenOrange,

        /// <summary>
        /// Maitree.
        /// </summary>
        [EnumMember(Value = "Maitree")]
        Maitree,

        /// <summary>
        /// EnumMajorMonoDisplay.
        /// </summary>
        [EnumMember(Value = "Major Mono Display")]
        EnumMajorMonoDisplay,

        /// <summary>
        /// Mako.
        /// </summary>
        [EnumMember(Value = "Mako")]
        Mako,

        /// <summary>
        /// Mali.
        /// </summary>
        [EnumMember(Value = "Mali")]
        Mali,

        /// <summary>
        /// Mallanna.
        /// </summary>
        [EnumMember(Value = "Mallanna")]
        Mallanna,

        /// <summary>
        /// Mandali.
        /// </summary>
        [EnumMember(Value = "Mandali")]
        Mandali,

        /// <summary>
        /// Manjari.
        /// </summary>
        [EnumMember(Value = "Manjari")]
        Manjari,

        /// <summary>
        /// Mansalva.
        /// </summary>
        [EnumMember(Value = "Mansalva")]
        Mansalva,

        /// <summary>
        /// Manuale.
        /// </summary>
        [EnumMember(Value = "Manuale")]
        Manuale,

        /// <summary>
        /// Marcellus.
        /// </summary>
        [EnumMember(Value = "Marcellus")]
        Marcellus,

        /// <summary>
        /// EnumMarcellusSC.
        /// </summary>
        [EnumMember(Value = "Marcellus SC")]
        EnumMarcellusSC,

        /// <summary>
        /// EnumMarckScript.
        /// </summary>
        [EnumMember(Value = "Marck Script")]
        EnumMarckScript,

        /// <summary>
        /// Margarine.
        /// </summary>
        [EnumMember(Value = "Margarine")]
        Margarine,

        /// <summary>
        /// EnumMarkaziText.
        /// </summary>
        [EnumMember(Value = "Markazi Text")]
        EnumMarkaziText,

        /// <summary>
        /// EnumMarkoOne.
        /// </summary>
        [EnumMember(Value = "Marko One")]
        EnumMarkoOne,

        /// <summary>
        /// Marmelad.
        /// </summary>
        [EnumMember(Value = "Marmelad")]
        Marmelad,

        /// <summary>
        /// Martel.
        /// </summary>
        [EnumMember(Value = "Martel")]
        Martel,

        /// <summary>
        /// EnumMartelSans.
        /// </summary>
        [EnumMember(Value = "Martel Sans")]
        EnumMartelSans,

        /// <summary>
        /// Marvel.
        /// </summary>
        [EnumMember(Value = "Marvel")]
        Marvel,

        /// <summary>
        /// Mate.
        /// </summary>
        [EnumMember(Value = "Mate")]
        Mate,

        /// <summary>
        /// EnumMateSC.
        /// </summary>
        [EnumMember(Value = "Mate SC")]
        EnumMateSC,

        /// <summary>
        /// EnumMavenPro.
        /// </summary>
        [EnumMember(Value = "Maven Pro")]
        EnumMavenPro,

        /// <summary>
        /// McLaren.
        /// </summary>
        [EnumMember(Value = "McLaren")]
        McLaren,

        /// <summary>
        /// Meddon.
        /// </summary>
        [EnumMember(Value = "Meddon")]
        Meddon,

        /// <summary>
        /// MedievalSharp.
        /// </summary>
        [EnumMember(Value = "MedievalSharp")]
        MedievalSharp,

        /// <summary>
        /// EnumMedulaOne.
        /// </summary>
        [EnumMember(Value = "Medula One")]
        EnumMedulaOne,

        /// <summary>
        /// EnumMeeraInimai.
        /// </summary>
        [EnumMember(Value = "Meera Inimai")]
        EnumMeeraInimai,

        /// <summary>
        /// Megrim.
        /// </summary>
        [EnumMember(Value = "Megrim")]
        Megrim,

        /// <summary>
        /// EnumMeieScript.
        /// </summary>
        [EnumMember(Value = "Meie Script")]
        EnumMeieScript,

        /// <summary>
        /// Merienda.
        /// </summary>
        [EnumMember(Value = "Merienda")]
        Merienda,

        /// <summary>
        /// EnumMeriendaOne.
        /// </summary>
        [EnumMember(Value = "Merienda One")]
        EnumMeriendaOne,

        /// <summary>
        /// Merriweather.
        /// </summary>
        [EnumMember(Value = "Merriweather")]
        Merriweather,

        /// <summary>
        /// EnumMerriweatherSans.
        /// </summary>
        [EnumMember(Value = "Merriweather Sans")]
        EnumMerriweatherSans,

        /// <summary>
        /// Metal.
        /// </summary>
        [EnumMember(Value = "Metal")]
        Metal,

        /// <summary>
        /// EnumMetalMania.
        /// </summary>
        [EnumMember(Value = "Metal Mania")]
        EnumMetalMania,

        /// <summary>
        /// Metamorphous.
        /// </summary>
        [EnumMember(Value = "Metamorphous")]
        Metamorphous,

        /// <summary>
        /// Metrophobic.
        /// </summary>
        [EnumMember(Value = "Metrophobic")]
        Metrophobic,

        /// <summary>
        /// Michroma.
        /// </summary>
        [EnumMember(Value = "Michroma")]
        Michroma,

        /// <summary>
        /// Milonga.
        /// </summary>
        [EnumMember(Value = "Milonga")]
        Milonga,

        /// <summary>
        /// Miltonian.
        /// </summary>
        [EnumMember(Value = "Miltonian")]
        Miltonian,

        /// <summary>
        /// EnumMiltonianTattoo.
        /// </summary>
        [EnumMember(Value = "Miltonian Tattoo")]
        EnumMiltonianTattoo,

        /// <summary>
        /// Mina.
        /// </summary>
        [EnumMember(Value = "Mina")]
        Mina,

        /// <summary>
        /// Miniver.
        /// </summary>
        [EnumMember(Value = "Miniver")]
        Miniver,

        /// <summary>
        /// EnumMiriamLibre.
        /// </summary>
        [EnumMember(Value = "Miriam Libre")]
        EnumMiriamLibre,

        /// <summary>
        /// Mirza.
        /// </summary>
        [EnumMember(Value = "Mirza")]
        Mirza,

        /// <summary>
        /// EnumMissFajardose.
        /// </summary>
        [EnumMember(Value = "Miss Fajardose")]
        EnumMissFajardose,

        /// <summary>
        /// Mitr.
        /// </summary>
        [EnumMember(Value = "Mitr")]
        Mitr,

        /// <summary>
        /// Modak.
        /// </summary>
        [EnumMember(Value = "Modak")]
        Modak,

        /// <summary>
        /// EnumModernAntiqua.
        /// </summary>
        [EnumMember(Value = "Modern Antiqua")]
        EnumModernAntiqua,

        /// <summary>
        /// Mogra.
        /// </summary>
        [EnumMember(Value = "Mogra")]
        Mogra,

        /// <summary>
        /// Molengo.
        /// </summary>
        [EnumMember(Value = "Molengo")]
        Molengo,

        /// <summary>
        /// Molle.
        /// </summary>
        [EnumMember(Value = "Molle")]
        Molle,

        /// <summary>
        /// Monda.
        /// </summary>
        [EnumMember(Value = "Monda")]
        Monda,

        /// <summary>
        /// Monofett.
        /// </summary>
        [EnumMember(Value = "Monofett")]
        Monofett,

        /// <summary>
        /// Monoton.
        /// </summary>
        [EnumMember(Value = "Monoton")]
        Monoton,

        /// <summary>
        /// EnumMonsieurLaDoulaise.
        /// </summary>
        [EnumMember(Value = "Monsieur La Doulaise")]
        EnumMonsieurLaDoulaise,

        /// <summary>
        /// Montaga.
        /// </summary>
        [EnumMember(Value = "Montaga")]
        Montaga,

        /// <summary>
        /// Montez.
        /// </summary>
        [EnumMember(Value = "Montez")]
        Montez,

        /// <summary>
        /// Montserrat.
        /// </summary>
        [EnumMember(Value = "Montserrat")]
        Montserrat,

        /// <summary>
        /// EnumMontserratAlternates.
        /// </summary>
        [EnumMember(Value = "Montserrat Alternates")]
        EnumMontserratAlternates,

        /// <summary>
        /// EnumMontserratSubrayada.
        /// </summary>
        [EnumMember(Value = "Montserrat Subrayada")]
        EnumMontserratSubrayada,

        /// <summary>
        /// Moul.
        /// </summary>
        [EnumMember(Value = "Moul")]
        Moul,

        /// <summary>
        /// Moulpali.
        /// </summary>
        [EnumMember(Value = "Moulpali")]
        Moulpali,

        /// <summary>
        /// EnumMountainsOfChristmas.
        /// </summary>
        [EnumMember(Value = "Mountains of Christmas")]
        EnumMountainsOfChristmas,

        /// <summary>
        /// EnumMouseMemoirs.
        /// </summary>
        [EnumMember(Value = "Mouse Memoirs")]
        EnumMouseMemoirs,

        /// <summary>
        /// EnumMrBedfort.
        /// </summary>
        [EnumMember(Value = "Mr Bedfort")]
        EnumMrBedfort,

        /// <summary>
        /// EnumMrDafoe.
        /// </summary>
        [EnumMember(Value = "Mr Dafoe")]
        EnumMrDafoe,

        /// <summary>
        /// EnumMrDeHaviland.
        /// </summary>
        [EnumMember(Value = "Mr De Haviland")]
        EnumMrDeHaviland,

        /// <summary>
        /// EnumMrsSaintDelafield.
        /// </summary>
        [EnumMember(Value = "Mrs Saint Delafield")]
        EnumMrsSaintDelafield,

        /// <summary>
        /// EnumMrsSheppards.
        /// </summary>
        [EnumMember(Value = "Mrs Sheppards")]
        EnumMrsSheppards,

        /// <summary>
        /// Mukta.
        /// </summary>
        [EnumMember(Value = "Mukta")]
        Mukta,

        /// <summary>
        /// EnumMuktaMahee.
        /// </summary>
        [EnumMember(Value = "Mukta Mahee")]
        EnumMuktaMahee,

        /// <summary>
        /// EnumMuktaMalar.
        /// </summary>
        [EnumMember(Value = "Mukta Malar")]
        EnumMuktaMalar,

        /// <summary>
        /// EnumMuktaVaani.
        /// </summary>
        [EnumMember(Value = "Mukta Vaani")]
        EnumMuktaVaani,

        /// <summary>
        /// Muli.
        /// </summary>
        [EnumMember(Value = "Muli")]
        Muli,

        /// <summary>
        /// EnumMysteryQuest.
        /// </summary>
        [EnumMember(Value = "Mystery Quest")]
        EnumMysteryQuest,

        /// <summary>
        /// NTR.
        /// </summary>
        [EnumMember(Value = "NTR")]
        NTR,

        /// <summary>
        /// EnumNanumBrushScript.
        /// </summary>
        [EnumMember(Value = "Nanum Brush Script")]
        EnumNanumBrushScript,

        /// <summary>
        /// EnumNanumGothic.
        /// </summary>
        [EnumMember(Value = "Nanum Gothic")]
        EnumNanumGothic,

        /// <summary>
        /// EnumNanumGothicCoding.
        /// </summary>
        [EnumMember(Value = "Nanum Gothic Coding")]
        EnumNanumGothicCoding,

        /// <summary>
        /// EnumNanumMyeongjo.
        /// </summary>
        [EnumMember(Value = "Nanum Myeongjo")]
        EnumNanumMyeongjo,

        /// <summary>
        /// EnumNanumPenScript.
        /// </summary>
        [EnumMember(Value = "Nanum Pen Script")]
        EnumNanumPenScript,

        /// <summary>
        /// Neucha.
        /// </summary>
        [EnumMember(Value = "Neucha")]
        Neucha,

        /// <summary>
        /// Neuton.
        /// </summary>
        [EnumMember(Value = "Neuton")]
        Neuton,

        /// <summary>
        /// EnumNewRocker.
        /// </summary>
        [EnumMember(Value = "New Rocker")]
        EnumNewRocker,

        /// <summary>
        /// EnumNewsCycle.
        /// </summary>
        [EnumMember(Value = "News Cycle")]
        EnumNewsCycle,

        /// <summary>
        /// Niconne.
        /// </summary>
        [EnumMember(Value = "Niconne")]
        Niconne,

        /// <summary>
        /// Niramit.
        /// </summary>
        [EnumMember(Value = "Niramit")]
        Niramit,

        /// <summary>
        /// EnumNixieOne.
        /// </summary>
        [EnumMember(Value = "Nixie One")]
        EnumNixieOne,

        /// <summary>
        /// Nobile.
        /// </summary>
        [EnumMember(Value = "Nobile")]
        Nobile,

        /// <summary>
        /// Nokora.
        /// </summary>
        [EnumMember(Value = "Nokora")]
        Nokora,

        /// <summary>
        /// Norican.
        /// </summary>
        [EnumMember(Value = "Norican")]
        Norican,

        /// <summary>
        /// Nosifer.
        /// </summary>
        [EnumMember(Value = "Nosifer")]
        Nosifer,

        /// <summary>
        /// Notable.
        /// </summary>
        [EnumMember(Value = "Notable")]
        Notable,

        /// <summary>
        /// EnumNothingYouCouldDo.
        /// </summary>
        [EnumMember(Value = "Nothing You Could Do")]
        EnumNothingYouCouldDo,

        /// <summary>
        /// EnumNoticiaText.
        /// </summary>
        [EnumMember(Value = "Noticia Text")]
        EnumNoticiaText,

        /// <summary>
        /// EnumNotoSans.
        /// </summary>
        [EnumMember(Value = "Noto Sans")]
        EnumNotoSans,

        /// <summary>
        /// EnumNotoSansHK.
        /// </summary>
        [EnumMember(Value = "Noto Sans HK")]
        EnumNotoSansHK,

        /// <summary>
        /// EnumNotoSansJP.
        /// </summary>
        [EnumMember(Value = "Noto Sans JP")]
        EnumNotoSansJP,

        /// <summary>
        /// EnumNotoSansKR.
        /// </summary>
        [EnumMember(Value = "Noto Sans KR")]
        EnumNotoSansKR,

        /// <summary>
        /// EnumNotoSansSC.
        /// </summary>
        [EnumMember(Value = "Noto Sans SC")]
        EnumNotoSansSC,

        /// <summary>
        /// EnumNotoSansTC.
        /// </summary>
        [EnumMember(Value = "Noto Sans TC")]
        EnumNotoSansTC,

        /// <summary>
        /// EnumNotoSerif.
        /// </summary>
        [EnumMember(Value = "Noto Serif")]
        EnumNotoSerif,

        /// <summary>
        /// EnumNotoSerifJP.
        /// </summary>
        [EnumMember(Value = "Noto Serif JP")]
        EnumNotoSerifJP,

        /// <summary>
        /// EnumNotoSerifKR.
        /// </summary>
        [EnumMember(Value = "Noto Serif KR")]
        EnumNotoSerifKR,

        /// <summary>
        /// EnumNotoSerifSC.
        /// </summary>
        [EnumMember(Value = "Noto Serif SC")]
        EnumNotoSerifSC,

        /// <summary>
        /// EnumNotoSerifTC.
        /// </summary>
        [EnumMember(Value = "Noto Serif TC")]
        EnumNotoSerifTC,

        /// <summary>
        /// EnumNovaCut.
        /// </summary>
        [EnumMember(Value = "Nova Cut")]
        EnumNovaCut,

        /// <summary>
        /// EnumNovaFlat.
        /// </summary>
        [EnumMember(Value = "Nova Flat")]
        EnumNovaFlat,

        /// <summary>
        /// EnumNovaMono.
        /// </summary>
        [EnumMember(Value = "Nova Mono")]
        EnumNovaMono,

        /// <summary>
        /// EnumNovaOval.
        /// </summary>
        [EnumMember(Value = "Nova Oval")]
        EnumNovaOval,

        /// <summary>
        /// EnumNovaRound.
        /// </summary>
        [EnumMember(Value = "Nova Round")]
        EnumNovaRound,

        /// <summary>
        /// EnumNovaScript.
        /// </summary>
        [EnumMember(Value = "Nova Script")]
        EnumNovaScript,

        /// <summary>
        /// EnumNovaSlim.
        /// </summary>
        [EnumMember(Value = "Nova Slim")]
        EnumNovaSlim,

        /// <summary>
        /// EnumNovaSquare.
        /// </summary>
        [EnumMember(Value = "Nova Square")]
        EnumNovaSquare,

        /// <summary>
        /// Numans.
        /// </summary>
        [EnumMember(Value = "Numans")]
        Numans,

        /// <summary>
        /// Nunito.
        /// </summary>
        [EnumMember(Value = "Nunito")]
        Nunito,

        /// <summary>
        /// EnumNunitoSans.
        /// </summary>
        [EnumMember(Value = "Nunito Sans")]
        EnumNunitoSans,

        /// <summary>
        /// EnumOdorMeanChey.
        /// </summary>
        [EnumMember(Value = "Odor Mean Chey")]
        EnumOdorMeanChey,

        /// <summary>
        /// Offside.
        /// </summary>
        [EnumMember(Value = "Offside")]
        Offside,

        /// <summary>
        /// EnumOldStandardTT.
        /// </summary>
        [EnumMember(Value = "Old Standard TT")]
        EnumOldStandardTT,

        /// <summary>
        /// Oldenburg.
        /// </summary>
        [EnumMember(Value = "Oldenburg")]
        Oldenburg,

        /// <summary>
        /// EnumOleoScript.
        /// </summary>
        [EnumMember(Value = "Oleo Script")]
        EnumOleoScript,

        /// <summary>
        /// EnumOleoScriptSwashCaps.
        /// </summary>
        [EnumMember(Value = "Oleo Script Swash Caps")]
        EnumOleoScriptSwashCaps,

        /// <summary>
        /// EnumOpenSans.
        /// </summary>
        [EnumMember(Value = "Open Sans")]
        EnumOpenSans,

        /// <summary>
        /// EnumOpenSansCondensed.
        /// </summary>
        [EnumMember(Value = "Open Sans Condensed")]
        EnumOpenSansCondensed,

        /// <summary>
        /// Oranienbaum.
        /// </summary>
        [EnumMember(Value = "Oranienbaum")]
        Oranienbaum,

        /// <summary>
        /// Orbitron.
        /// </summary>
        [EnumMember(Value = "Orbitron")]
        Orbitron,

        /// <summary>
        /// Oregano.
        /// </summary>
        [EnumMember(Value = "Oregano")]
        Oregano,

        /// <summary>
        /// Orienta.
        /// </summary>
        [EnumMember(Value = "Orienta")]
        Orienta,

        /// <summary>
        /// EnumOriginalSurfer.
        /// </summary>
        [EnumMember(Value = "Original Surfer")]
        EnumOriginalSurfer,

        /// <summary>
        /// Oswald.
        /// </summary>
        [EnumMember(Value = "Oswald")]
        Oswald,

        /// <summary>
        /// EnumOverTheRainbow.
        /// </summary>
        [EnumMember(Value = "Over the Rainbow")]
        EnumOverTheRainbow,

        /// <summary>
        /// Overlock.
        /// </summary>
        [EnumMember(Value = "Overlock")]
        Overlock,

        /// <summary>
        /// EnumOverlockSC.
        /// </summary>
        [EnumMember(Value = "Overlock SC")]
        EnumOverlockSC,

        /// <summary>
        /// Overpass.
        /// </summary>
        [EnumMember(Value = "Overpass")]
        Overpass,

        /// <summary>
        /// EnumOverpassMono.
        /// </summary>
        [EnumMember(Value = "Overpass Mono")]
        EnumOverpassMono,

        /// <summary>
        /// Ovo.
        /// </summary>
        [EnumMember(Value = "Ovo")]
        Ovo,

        /// <summary>
        /// Oxygen.
        /// </summary>
        [EnumMember(Value = "Oxygen")]
        Oxygen,

        /// <summary>
        /// EnumOxygenMono.
        /// </summary>
        [EnumMember(Value = "Oxygen Mono")]
        EnumOxygenMono,

        /// <summary>
        /// EnumPTMono.
        /// </summary>
        [EnumMember(Value = "PT Mono")]
        EnumPTMono,

        /// <summary>
        /// EnumPTSans.
        /// </summary>
        [EnumMember(Value = "PT Sans")]
        EnumPTSans,

        /// <summary>
        /// EnumPTSansCaption.
        /// </summary>
        [EnumMember(Value = "PT Sans Caption")]
        EnumPTSansCaption,

        /// <summary>
        /// EnumPTSansNarrow.
        /// </summary>
        [EnumMember(Value = "PT Sans Narrow")]
        EnumPTSansNarrow,

        /// <summary>
        /// EnumPTSerif.
        /// </summary>
        [EnumMember(Value = "PT Serif")]
        EnumPTSerif,

        /// <summary>
        /// EnumPTSerifCaption.
        /// </summary>
        [EnumMember(Value = "PT Serif Caption")]
        EnumPTSerifCaption,

        /// <summary>
        /// Pacifico.
        /// </summary>
        [EnumMember(Value = "Pacifico")]
        Pacifico,

        /// <summary>
        /// Padauk.
        /// </summary>
        [EnumMember(Value = "Padauk")]
        Padauk,

        /// <summary>
        /// Palanquin.
        /// </summary>
        [EnumMember(Value = "Palanquin")]
        Palanquin,

        /// <summary>
        /// EnumPalanquinDark.
        /// </summary>
        [EnumMember(Value = "Palanquin Dark")]
        EnumPalanquinDark,

        /// <summary>
        /// Pangolin.
        /// </summary>
        [EnumMember(Value = "Pangolin")]
        Pangolin,

        /// <summary>
        /// Paprika.
        /// </summary>
        [EnumMember(Value = "Paprika")]
        Paprika,

        /// <summary>
        /// Parisienne.
        /// </summary>
        [EnumMember(Value = "Parisienne")]
        Parisienne,

        /// <summary>
        /// EnumPasseroOne.
        /// </summary>
        [EnumMember(Value = "Passero One")]
        EnumPasseroOne,

        /// <summary>
        /// EnumPassionOne.
        /// </summary>
        [EnumMember(Value = "Passion One")]
        EnumPassionOne,

        /// <summary>
        /// EnumPathwayGothicOne.
        /// </summary>
        [EnumMember(Value = "Pathway Gothic One")]
        EnumPathwayGothicOne,

        /// <summary>
        /// EnumPatrickHand.
        /// </summary>
        [EnumMember(Value = "Patrick Hand")]
        EnumPatrickHand,

        /// <summary>
        /// EnumPatrickHandSC.
        /// </summary>
        [EnumMember(Value = "Patrick Hand SC")]
        EnumPatrickHandSC,

        /// <summary>
        /// Pattaya.
        /// </summary>
        [EnumMember(Value = "Pattaya")]
        Pattaya,

        /// <summary>
        /// EnumPatuaOne.
        /// </summary>
        [EnumMember(Value = "Patua One")]
        EnumPatuaOne,

        /// <summary>
        /// Pavanam.
        /// </summary>
        [EnumMember(Value = "Pavanam")]
        Pavanam,

        /// <summary>
        /// EnumPaytoneOne.
        /// </summary>
        [EnumMember(Value = "Paytone One")]
        EnumPaytoneOne,

        /// <summary>
        /// Peddana.
        /// </summary>
        [EnumMember(Value = "Peddana")]
        Peddana,

        /// <summary>
        /// Peralta.
        /// </summary>
        [EnumMember(Value = "Peralta")]
        Peralta,

        /// <summary>
        /// EnumPermanentMarker.
        /// </summary>
        [EnumMember(Value = "Permanent Marker")]
        EnumPermanentMarker,

        /// <summary>
        /// EnumPetitFormalScript.
        /// </summary>
        [EnumMember(Value = "Petit Formal Script")]
        EnumPetitFormalScript,

        /// <summary>
        /// Petrona.
        /// </summary>
        [EnumMember(Value = "Petrona")]
        Petrona,

        /// <summary>
        /// Philosopher.
        /// </summary>
        [EnumMember(Value = "Philosopher")]
        Philosopher,

        /// <summary>
        /// Piedra.
        /// </summary>
        [EnumMember(Value = "Piedra")]
        Piedra,

        /// <summary>
        /// EnumPinyonScript.
        /// </summary>
        [EnumMember(Value = "Pinyon Script")]
        EnumPinyonScript,

        /// <summary>
        /// EnumPirataOne.
        /// </summary>
        [EnumMember(Value = "Pirata One")]
        EnumPirataOne,

        /// <summary>
        /// Plaster.
        /// </summary>
        [EnumMember(Value = "Plaster")]
        Plaster,

        /// <summary>
        /// Play.
        /// </summary>
        [EnumMember(Value = "Play")]
        Play,

        /// <summary>
        /// Playball.
        /// </summary>
        [EnumMember(Value = "Playball")]
        Playball,

        /// <summary>
        /// EnumPlayfairDisplay.
        /// </summary>
        [EnumMember(Value = "Playfair Display")]
        EnumPlayfairDisplay,

        /// <summary>
        /// EnumPlayfairDisplaySC.
        /// </summary>
        [EnumMember(Value = "Playfair Display SC")]
        EnumPlayfairDisplaySC,

        /// <summary>
        /// Podkova.
        /// </summary>
        [EnumMember(Value = "Podkova")]
        Podkova,

        /// <summary>
        /// EnumPoiretOne.
        /// </summary>
        [EnumMember(Value = "Poiret One")]
        EnumPoiretOne,

        /// <summary>
        /// EnumPollerOne.
        /// </summary>
        [EnumMember(Value = "Poller One")]
        EnumPollerOne,

        /// <summary>
        /// Poly.
        /// </summary>
        [EnumMember(Value = "Poly")]
        Poly,

        /// <summary>
        /// Pompiere.
        /// </summary>
        [EnumMember(Value = "Pompiere")]
        Pompiere,

        /// <summary>
        /// EnumPontanoSans.
        /// </summary>
        [EnumMember(Value = "Pontano Sans")]
        EnumPontanoSans,

        /// <summary>
        /// EnumPoorStory.
        /// </summary>
        [EnumMember(Value = "Poor Story")]
        EnumPoorStory,

        /// <summary>
        /// Poppins.
        /// </summary>
        [EnumMember(Value = "Poppins")]
        Poppins,

        /// <summary>
        /// EnumPortLligatSans.
        /// </summary>
        [EnumMember(Value = "Port Lligat Sans")]
        EnumPortLligatSans,

        /// <summary>
        /// EnumPortLligatSlab.
        /// </summary>
        [EnumMember(Value = "Port Lligat Slab")]
        EnumPortLligatSlab,

        /// <summary>
        /// EnumPragatiNarrow.
        /// </summary>
        [EnumMember(Value = "Pragati Narrow")]
        EnumPragatiNarrow,

        /// <summary>
        /// Prata.
        /// </summary>
        [EnumMember(Value = "Prata")]
        Prata,

        /// <summary>
        /// Preahvihear.
        /// </summary>
        [EnumMember(Value = "Preahvihear")]
        Preahvihear,

        /// <summary>
        /// EnumPressStart2P.
        /// </summary>
        [EnumMember(Value = "Press Start 2P")]
        EnumPressStart2P,

        /// <summary>
        /// Pridi.
        /// </summary>
        [EnumMember(Value = "Pridi")]
        Pridi,

        /// <summary>
        /// EnumPrincessSofia.
        /// </summary>
        [EnumMember(Value = "Princess Sofia")]
        EnumPrincessSofia,

        /// <summary>
        /// Prociono.
        /// </summary>
        [EnumMember(Value = "Prociono")]
        Prociono,

        /// <summary>
        /// Prompt.
        /// </summary>
        [EnumMember(Value = "Prompt")]
        Prompt,

        /// <summary>
        /// EnumProstoOne.
        /// </summary>
        [EnumMember(Value = "Prosto One")]
        EnumProstoOne,

        /// <summary>
        /// EnumProzaLibre.
        /// </summary>
        [EnumMember(Value = "Proza Libre")]
        EnumProzaLibre,

        /// <summary>
        /// Puritan.
        /// </summary>
        [EnumMember(Value = "Puritan")]
        Puritan,

        /// <summary>
        /// EnumPurplePurse.
        /// </summary>
        [EnumMember(Value = "Purple Purse")]
        EnumPurplePurse,

        /// <summary>
        /// Quando.
        /// </summary>
        [EnumMember(Value = "Quando")]
        Quando,

        /// <summary>
        /// Quantico.
        /// </summary>
        [EnumMember(Value = "Quantico")]
        Quantico,

        /// <summary>
        /// Quattrocento.
        /// </summary>
        [EnumMember(Value = "Quattrocento")]
        Quattrocento,

        /// <summary>
        /// EnumQuattrocentoSans.
        /// </summary>
        [EnumMember(Value = "Quattrocento Sans")]
        EnumQuattrocentoSans,

        /// <summary>
        /// Questrial.
        /// </summary>
        [EnumMember(Value = "Questrial")]
        Questrial,

        /// <summary>
        /// Quicksand.
        /// </summary>
        [EnumMember(Value = "Quicksand")]
        Quicksand,

        /// <summary>
        /// Quintessential.
        /// </summary>
        [EnumMember(Value = "Quintessential")]
        Quintessential,

        /// <summary>
        /// Qwigley.
        /// </summary>
        [EnumMember(Value = "Qwigley")]
        Qwigley,

        /// <summary>
        /// EnumRacingSansOne.
        /// </summary>
        [EnumMember(Value = "Racing Sans One")]
        EnumRacingSansOne,

        /// <summary>
        /// Radley.
        /// </summary>
        [EnumMember(Value = "Radley")]
        Radley,

        /// <summary>
        /// Rajdhani.
        /// </summary>
        [EnumMember(Value = "Rajdhani")]
        Rajdhani,

        /// <summary>
        /// Rakkas.
        /// </summary>
        [EnumMember(Value = "Rakkas")]
        Rakkas,

        /// <summary>
        /// Raleway.
        /// </summary>
        [EnumMember(Value = "Raleway")]
        Raleway,

        /// <summary>
        /// EnumRalewayDots.
        /// </summary>
        [EnumMember(Value = "Raleway Dots")]
        EnumRalewayDots,

        /// <summary>
        /// Ramabhadra.
        /// </summary>
        [EnumMember(Value = "Ramabhadra")]
        Ramabhadra,

        /// <summary>
        /// Ramaraja.
        /// </summary>
        [EnumMember(Value = "Ramaraja")]
        Ramaraja,

        /// <summary>
        /// Rambla.
        /// </summary>
        [EnumMember(Value = "Rambla")]
        Rambla,

        /// <summary>
        /// EnumRammettoOne.
        /// </summary>
        [EnumMember(Value = "Rammetto One")]
        EnumRammettoOne,

        /// <summary>
        /// Ranchers.
        /// </summary>
        [EnumMember(Value = "Ranchers")]
        Ranchers,

        /// <summary>
        /// Rancho.
        /// </summary>
        [EnumMember(Value = "Rancho")]
        Rancho,

        /// <summary>
        /// Ranga.
        /// </summary>
        [EnumMember(Value = "Ranga")]
        Ranga,

        /// <summary>
        /// Rasa.
        /// </summary>
        [EnumMember(Value = "Rasa")]
        Rasa,

        /// <summary>
        /// Rationale.
        /// </summary>
        [EnumMember(Value = "Rationale")]
        Rationale,

        /// <summary>
        /// EnumRaviPrakash.
        /// </summary>
        [EnumMember(Value = "Ravi Prakash")]
        EnumRaviPrakash,

        /// <summary>
        /// EnumRedHatDisplay.
        /// </summary>
        [EnumMember(Value = "Red Hat Display")]
        EnumRedHatDisplay,

        /// <summary>
        /// EnumRedHatText.
        /// </summary>
        [EnumMember(Value = "Red Hat Text")]
        EnumRedHatText,

        /// <summary>
        /// Redressed.
        /// </summary>
        [EnumMember(Value = "Redressed")]
        Redressed,

        /// <summary>
        /// EnumReemKufi.
        /// </summary>
        [EnumMember(Value = "Reem Kufi")]
        EnumReemKufi,

        /// <summary>
        /// EnumReenieBeanie.
        /// </summary>
        [EnumMember(Value = "Reenie Beanie")]
        EnumReenieBeanie,

        /// <summary>
        /// Revalia.
        /// </summary>
        [EnumMember(Value = "Revalia")]
        Revalia,

        /// <summary>
        /// EnumRhodiumLibre.
        /// </summary>
        [EnumMember(Value = "Rhodium Libre")]
        EnumRhodiumLibre,

        /// <summary>
        /// Ribeye.
        /// </summary>
        [EnumMember(Value = "Ribeye")]
        Ribeye,

        /// <summary>
        /// EnumRibeyeMarrow.
        /// </summary>
        [EnumMember(Value = "Ribeye Marrow")]
        EnumRibeyeMarrow,

        /// <summary>
        /// Righteous.
        /// </summary>
        [EnumMember(Value = "Righteous")]
        Righteous,

        /// <summary>
        /// Risque.
        /// </summary>
        [EnumMember(Value = "Risque")]
        Risque,

        /// <summary>
        /// Roboto.
        /// </summary>
        [EnumMember(Value = "Roboto")]
        Roboto,

        /// <summary>
        /// EnumRobotoCondensed.
        /// </summary>
        [EnumMember(Value = "Roboto Condensed")]
        EnumRobotoCondensed,

        /// <summary>
        /// EnumRobotoMono.
        /// </summary>
        [EnumMember(Value = "Roboto Mono")]
        EnumRobotoMono,

        /// <summary>
        /// EnumRobotoSlab.
        /// </summary>
        [EnumMember(Value = "Roboto Slab")]
        EnumRobotoSlab,

        /// <summary>
        /// Rochester.
        /// </summary>
        [EnumMember(Value = "Rochester")]
        Rochester,

        /// <summary>
        /// EnumRockSalt.
        /// </summary>
        [EnumMember(Value = "Rock Salt")]
        EnumRockSalt,

        /// <summary>
        /// Rokkitt.
        /// </summary>
        [EnumMember(Value = "Rokkitt")]
        Rokkitt,

        /// <summary>
        /// Romanesco.
        /// </summary>
        [EnumMember(Value = "Romanesco")]
        Romanesco,

        /// <summary>
        /// EnumRopaSans.
        /// </summary>
        [EnumMember(Value = "Ropa Sans")]
        EnumRopaSans,

        /// <summary>
        /// Rosario.
        /// </summary>
        [EnumMember(Value = "Rosario")]
        Rosario,

        /// <summary>
        /// Rosarivo.
        /// </summary>
        [EnumMember(Value = "Rosarivo")]
        Rosarivo,

        /// <summary>
        /// EnumRougeScript.
        /// </summary>
        [EnumMember(Value = "Rouge Script")]
        EnumRougeScript,

        /// <summary>
        /// EnumRozhaOne.
        /// </summary>
        [EnumMember(Value = "Rozha One")]
        EnumRozhaOne,

        /// <summary>
        /// Rubik.
        /// </summary>
        [EnumMember(Value = "Rubik")]
        Rubik,

        /// <summary>
        /// EnumRubikMonoOne.
        /// </summary>
        [EnumMember(Value = "Rubik Mono One")]
        EnumRubikMonoOne,

        /// <summary>
        /// Ruda.
        /// </summary>
        [EnumMember(Value = "Ruda")]
        Ruda,

        /// <summary>
        /// Rufina.
        /// </summary>
        [EnumMember(Value = "Rufina")]
        Rufina,

        /// <summary>
        /// EnumRugeBoogie.
        /// </summary>
        [EnumMember(Value = "Ruge Boogie")]
        EnumRugeBoogie,

        /// <summary>
        /// Ruluko.
        /// </summary>
        [EnumMember(Value = "Ruluko")]
        Ruluko,

        /// <summary>
        /// EnumRumRaisin.
        /// </summary>
        [EnumMember(Value = "Rum Raisin")]
        EnumRumRaisin,

        /// <summary>
        /// EnumRuslanDisplay.
        /// </summary>
        [EnumMember(Value = "Ruslan Display")]
        EnumRuslanDisplay,

        /// <summary>
        /// EnumRussoOne.
        /// </summary>
        [EnumMember(Value = "Russo One")]
        EnumRussoOne,

        /// <summary>
        /// Ruthie.
        /// </summary>
        [EnumMember(Value = "Ruthie")]
        Ruthie,

        /// <summary>
        /// Rye.
        /// </summary>
        [EnumMember(Value = "Rye")]
        Rye,

        /// <summary>
        /// Sacramento.
        /// </summary>
        [EnumMember(Value = "Sacramento")]
        Sacramento,

        /// <summary>
        /// Sahitya.
        /// </summary>
        [EnumMember(Value = "Sahitya")]
        Sahitya,

        /// <summary>
        /// Sail.
        /// </summary>
        [EnumMember(Value = "Sail")]
        Sail,

        /// <summary>
        /// Saira.
        /// </summary>
        [EnumMember(Value = "Saira")]
        Saira,

        /// <summary>
        /// EnumSairaCondensed.
        /// </summary>
        [EnumMember(Value = "Saira Condensed")]
        EnumSairaCondensed,

        /// <summary>
        /// EnumSairaExtraCondensed.
        /// </summary>
        [EnumMember(Value = "Saira Extra Condensed")]
        EnumSairaExtraCondensed,

        /// <summary>
        /// EnumSairaSemiCondensed.
        /// </summary>
        [EnumMember(Value = "Saira Semi Condensed")]
        EnumSairaSemiCondensed,

        /// <summary>
        /// EnumSairaStencilOne.
        /// </summary>
        [EnumMember(Value = "Saira Stencil One")]
        EnumSairaStencilOne,

        /// <summary>
        /// Salsa.
        /// </summary>
        [EnumMember(Value = "Salsa")]
        Salsa,

        /// <summary>
        /// Sanchez.
        /// </summary>
        [EnumMember(Value = "Sanchez")]
        Sanchez,

        /// <summary>
        /// Sancreek.
        /// </summary>
        [EnumMember(Value = "Sancreek")]
        Sancreek,

        /// <summary>
        /// Sansita.
        /// </summary>
        [EnumMember(Value = "Sansita")]
        Sansita,

        /// <summary>
        /// Sarabun.
        /// </summary>
        [EnumMember(Value = "Sarabun")]
        Sarabun,

        /// <summary>
        /// Sarala.
        /// </summary>
        [EnumMember(Value = "Sarala")]
        Sarala,

        /// <summary>
        /// Sarina.
        /// </summary>
        [EnumMember(Value = "Sarina")]
        Sarina,

        /// <summary>
        /// Sarpanch.
        /// </summary>
        [EnumMember(Value = "Sarpanch")]
        Sarpanch,

        /// <summary>
        /// Satisfy.
        /// </summary>
        [EnumMember(Value = "Satisfy")]
        Satisfy,

        /// <summary>
        /// EnumSawarabiGothic.
        /// </summary>
        [EnumMember(Value = "Sawarabi Gothic")]
        EnumSawarabiGothic,

        /// <summary>
        /// EnumSawarabiMincho.
        /// </summary>
        [EnumMember(Value = "Sawarabi Mincho")]
        EnumSawarabiMincho,

        /// <summary>
        /// Scada.
        /// </summary>
        [EnumMember(Value = "Scada")]
        Scada,

        /// <summary>
        /// Scheherazade.
        /// </summary>
        [EnumMember(Value = "Scheherazade")]
        Scheherazade,

        /// <summary>
        /// Schoolbell.
        /// </summary>
        [EnumMember(Value = "Schoolbell")]
        Schoolbell,

        /// <summary>
        /// EnumScopeOne.
        /// </summary>
        [EnumMember(Value = "Scope One")]
        EnumScopeOne,

        /// <summary>
        /// EnumSeaweedScript.
        /// </summary>
        [EnumMember(Value = "Seaweed Script")]
        EnumSeaweedScript,

        /// <summary>
        /// EnumSecularOne.
        /// </summary>
        [EnumMember(Value = "Secular One")]
        EnumSecularOne,

        /// <summary>
        /// EnumSedgwickAve.
        /// </summary>
        [EnumMember(Value = "Sedgwick Ave")]
        EnumSedgwickAve,

        /// <summary>
        /// EnumSedgwickAveDisplay.
        /// </summary>
        [EnumMember(Value = "Sedgwick Ave Display")]
        EnumSedgwickAveDisplay,

        /// <summary>
        /// Sevillana.
        /// </summary>
        [EnumMember(Value = "Sevillana")]
        Sevillana,

        /// <summary>
        /// EnumSeymourOne.
        /// </summary>
        [EnumMember(Value = "Seymour One")]
        EnumSeymourOne,

        /// <summary>
        /// EnumShadowsIntoLight.
        /// </summary>
        [EnumMember(Value = "Shadows Into Light")]
        EnumShadowsIntoLight,

        /// <summary>
        /// EnumShadowsIntoLightTwo.
        /// </summary>
        [EnumMember(Value = "Shadows Into Light Two")]
        EnumShadowsIntoLightTwo,

        /// <summary>
        /// Shanti.
        /// </summary>
        [EnumMember(Value = "Shanti")]
        Shanti,

        /// <summary>
        /// Share.
        /// </summary>
        [EnumMember(Value = "Share")]
        Share,

        /// <summary>
        /// EnumShareTech.
        /// </summary>
        [EnumMember(Value = "Share Tech")]
        EnumShareTech,

        /// <summary>
        /// EnumShareTechMono.
        /// </summary>
        [EnumMember(Value = "Share Tech Mono")]
        EnumShareTechMono,

        /// <summary>
        /// Shojumaru.
        /// </summary>
        [EnumMember(Value = "Shojumaru")]
        Shojumaru,

        /// <summary>
        /// EnumShortStack.
        /// </summary>
        [EnumMember(Value = "Short Stack")]
        EnumShortStack,

        /// <summary>
        /// Shrikhand.
        /// </summary>
        [EnumMember(Value = "Shrikhand")]
        Shrikhand,

        /// <summary>
        /// Siemreap.
        /// </summary>
        [EnumMember(Value = "Siemreap")]
        Siemreap,

        /// <summary>
        /// EnumSigmarOne.
        /// </summary>
        [EnumMember(Value = "Sigmar One")]
        EnumSigmarOne,

        /// <summary>
        /// Signika.
        /// </summary>
        [EnumMember(Value = "Signika")]
        Signika,

        /// <summary>
        /// EnumSignikaNegative.
        /// </summary>
        [EnumMember(Value = "Signika Negative")]
        EnumSignikaNegative,

        /// <summary>
        /// Simonetta.
        /// </summary>
        [EnumMember(Value = "Simonetta")]
        Simonetta,

        /// <summary>
        /// EnumSingleDay.
        /// </summary>
        [EnumMember(Value = "Single Day")]
        EnumSingleDay,

        /// <summary>
        /// Sintony.
        /// </summary>
        [EnumMember(Value = "Sintony")]
        Sintony,

        /// <summary>
        /// EnumSirinStencil.
        /// </summary>
        [EnumMember(Value = "Sirin Stencil")]
        EnumSirinStencil,

        /// <summary>
        /// EnumSixCaps.
        /// </summary>
        [EnumMember(Value = "Six Caps")]
        EnumSixCaps,

        /// <summary>
        /// Skranji.
        /// </summary>
        [EnumMember(Value = "Skranji")]
        Skranji,

        /// <summary>
        /// EnumSlabo13px.
        /// </summary>
        [EnumMember(Value = "Slabo 13px")]
        EnumSlabo13px,

        /// <summary>
        /// EnumSlabo27px.
        /// </summary>
        [EnumMember(Value = "Slabo 27px")]
        EnumSlabo27px,

        /// <summary>
        /// Slackey.
        /// </summary>
        [EnumMember(Value = "Slackey")]
        Slackey,

        /// <summary>
        /// Smokum.
        /// </summary>
        [EnumMember(Value = "Smokum")]
        Smokum,

        /// <summary>
        /// Smythe.
        /// </summary>
        [EnumMember(Value = "Smythe")]
        Smythe,

        /// <summary>
        /// Sniglet.
        /// </summary>
        [EnumMember(Value = "Sniglet")]
        Sniglet,

        /// <summary>
        /// Snippet.
        /// </summary>
        [EnumMember(Value = "Snippet")]
        Snippet,

        /// <summary>
        /// EnumSnowburstOne.
        /// </summary>
        [EnumMember(Value = "Snowburst One")]
        EnumSnowburstOne,

        /// <summary>
        /// EnumSofadiOne.
        /// </summary>
        [EnumMember(Value = "Sofadi One")]
        EnumSofadiOne,

        /// <summary>
        /// Sofia.
        /// </summary>
        [EnumMember(Value = "Sofia")]
        Sofia,

        /// <summary>
        /// EnumSongMyung.
        /// </summary>
        [EnumMember(Value = "Song Myung")]
        EnumSongMyung,

        /// <summary>
        /// EnumSonsieOne.
        /// </summary>
        [EnumMember(Value = "Sonsie One")]
        EnumSonsieOne,

        /// <summary>
        /// EnumSortsMillGoudy.
        /// </summary>
        [EnumMember(Value = "Sorts Mill Goudy")]
        EnumSortsMillGoudy,

        /// <summary>
        /// EnumSourceCodePro.
        /// </summary>
        [EnumMember(Value = "Source Code Pro")]
        EnumSourceCodePro,

        /// <summary>
        /// EnumSourceSansPro.
        /// </summary>
        [EnumMember(Value = "Source Sans Pro")]
        EnumSourceSansPro,

        /// <summary>
        /// EnumSourceSerifPro.
        /// </summary>
        [EnumMember(Value = "Source Serif Pro")]
        EnumSourceSerifPro,

        /// <summary>
        /// EnumSpaceMono.
        /// </summary>
        [EnumMember(Value = "Space Mono")]
        EnumSpaceMono,

        /// <summary>
        /// EnumSpecialElite.
        /// </summary>
        [EnumMember(Value = "Special Elite")]
        EnumSpecialElite,

        /// <summary>
        /// Spectral.
        /// </summary>
        [EnumMember(Value = "Spectral")]
        Spectral,

        /// <summary>
        /// EnumSpectralSC.
        /// </summary>
        [EnumMember(Value = "Spectral SC")]
        EnumSpectralSC,

        /// <summary>
        /// EnumSpicyRice.
        /// </summary>
        [EnumMember(Value = "Spicy Rice")]
        EnumSpicyRice,

        /// <summary>
        /// Spinnaker.
        /// </summary>
        [EnumMember(Value = "Spinnaker")]
        Spinnaker,

        /// <summary>
        /// Spirax.
        /// </summary>
        [EnumMember(Value = "Spirax")]
        Spirax,

        /// <summary>
        /// EnumSquadaOne.
        /// </summary>
        [EnumMember(Value = "Squada One")]
        EnumSquadaOne,

        /// <summary>
        /// EnumSreeKrushnadevaraya.
        /// </summary>
        [EnumMember(Value = "Sree Krushnadevaraya")]
        EnumSreeKrushnadevaraya,

        /// <summary>
        /// Sriracha.
        /// </summary>
        [EnumMember(Value = "Sriracha")]
        Sriracha,

        /// <summary>
        /// Srisakdi.
        /// </summary>
        [EnumMember(Value = "Srisakdi")]
        Srisakdi,

        /// <summary>
        /// Staatliches.
        /// </summary>
        [EnumMember(Value = "Staatliches")]
        Staatliches,

        /// <summary>
        /// Stalemate.
        /// </summary>
        [EnumMember(Value = "Stalemate")]
        Stalemate,

        /// <summary>
        /// EnumStalinistOne.
        /// </summary>
        [EnumMember(Value = "Stalinist One")]
        EnumStalinistOne,

        /// <summary>
        /// EnumStardosStencil.
        /// </summary>
        [EnumMember(Value = "Stardos Stencil")]
        EnumStardosStencil,

        /// <summary>
        /// EnumStintUltraCondensed.
        /// </summary>
        [EnumMember(Value = "Stint Ultra Condensed")]
        EnumStintUltraCondensed,

        /// <summary>
        /// EnumStintUltraExpanded.
        /// </summary>
        [EnumMember(Value = "Stint Ultra Expanded")]
        EnumStintUltraExpanded,

        /// <summary>
        /// Stoke.
        /// </summary>
        [EnumMember(Value = "Stoke")]
        Stoke,

        /// <summary>
        /// Strait.
        /// </summary>
        [EnumMember(Value = "Strait")]
        Strait,

        /// <summary>
        /// Stylish.
        /// </summary>
        [EnumMember(Value = "Stylish")]
        Stylish,

        /// <summary>
        /// EnumSueEllenFrancisco.
        /// </summary>
        [EnumMember(Value = "Sue Ellen Francisco")]
        EnumSueEllenFrancisco,

        /// <summary>
        /// EnumSuezOne.
        /// </summary>
        [EnumMember(Value = "Suez One")]
        EnumSuezOne,

        /// <summary>
        /// Sumana.
        /// </summary>
        [EnumMember(Value = "Sumana")]
        Sumana,

        /// <summary>
        /// Sunflower.
        /// </summary>
        [EnumMember(Value = "Sunflower")]
        Sunflower,

        /// <summary>
        /// Sunshiney.
        /// </summary>
        [EnumMember(Value = "Sunshiney")]
        Sunshiney,

        /// <summary>
        /// EnumSupermercadoOne.
        /// </summary>
        [EnumMember(Value = "Supermercado One")]
        EnumSupermercadoOne,

        /// <summary>
        /// Sura.
        /// </summary>
        [EnumMember(Value = "Sura")]
        Sura,

        /// <summary>
        /// Suranna.
        /// </summary>
        [EnumMember(Value = "Suranna")]
        Suranna,

        /// <summary>
        /// Suravaram.
        /// </summary>
        [EnumMember(Value = "Suravaram")]
        Suravaram,

        /// <summary>
        /// Suwannaphum.
        /// </summary>
        [EnumMember(Value = "Suwannaphum")]
        Suwannaphum,

        /// <summary>
        /// EnumSwankyAndMooMoo.
        /// </summary>
        [EnumMember(Value = "Swanky and Moo Moo")]
        EnumSwankyAndMooMoo,

        /// <summary>
        /// Syncopate.
        /// </summary>
        [EnumMember(Value = "Syncopate")]
        Syncopate,

        /// <summary>
        /// Tajawal.
        /// </summary>
        [EnumMember(Value = "Tajawal")]
        Tajawal,

        /// <summary>
        /// Tangerine.
        /// </summary>
        [EnumMember(Value = "Tangerine")]
        Tangerine,

        /// <summary>
        /// Taprom.
        /// </summary>
        [EnumMember(Value = "Taprom")]
        Taprom,

        /// <summary>
        /// Tauri.
        /// </summary>
        [EnumMember(Value = "Tauri")]
        Tauri,

        /// <summary>
        /// Taviraj.
        /// </summary>
        [EnumMember(Value = "Taviraj")]
        Taviraj,

        /// <summary>
        /// Teko.
        /// </summary>
        [EnumMember(Value = "Teko")]
        Teko,

        /// <summary>
        /// Telex.
        /// </summary>
        [EnumMember(Value = "Telex")]
        Telex,

        /// <summary>
        /// EnumTenaliRamakrishna.
        /// </summary>
        [EnumMember(Value = "Tenali Ramakrishna")]
        EnumTenaliRamakrishna,

        /// <summary>
        /// EnumTenorSans.
        /// </summary>
        [EnumMember(Value = "Tenor Sans")]
        EnumTenorSans,

        /// <summary>
        /// EnumTextMeOne.
        /// </summary>
        [EnumMember(Value = "Text Me One")]
        EnumTextMeOne,

        /// <summary>
        /// Thasadith.
        /// </summary>
        [EnumMember(Value = "Thasadith")]
        Thasadith,

        /// <summary>
        /// EnumTheGirlNextDoor.
        /// </summary>
        [EnumMember(Value = "The Girl Next Door")]
        EnumTheGirlNextDoor,

        /// <summary>
        /// Tienne.
        /// </summary>
        [EnumMember(Value = "Tienne")]
        Tienne,

        /// <summary>
        /// Tillana.
        /// </summary>
        [EnumMember(Value = "Tillana")]
        Tillana,

        /// <summary>
        /// Timmana.
        /// </summary>
        [EnumMember(Value = "Timmana")]
        Timmana,

        /// <summary>
        /// Tinos.
        /// </summary>
        [EnumMember(Value = "Tinos")]
        Tinos,

        /// <summary>
        /// EnumTitanOne.
        /// </summary>
        [EnumMember(Value = "Titan One")]
        EnumTitanOne,

        /// <summary>
        /// EnumTitilliumWeb.
        /// </summary>
        [EnumMember(Value = "Titillium Web")]
        EnumTitilliumWeb,

        /// <summary>
        /// EnumTradeWinds.
        /// </summary>
        [EnumMember(Value = "Trade Winds")]
        EnumTradeWinds,

        /// <summary>
        /// Trirong.
        /// </summary>
        [EnumMember(Value = "Trirong")]
        Trirong,

        /// <summary>
        /// Trocchi.
        /// </summary>
        [EnumMember(Value = "Trocchi")]
        Trocchi,

        /// <summary>
        /// Trochut.
        /// </summary>
        [EnumMember(Value = "Trochut")]
        Trochut,

        /// <summary>
        /// Trykker.
        /// </summary>
        [EnumMember(Value = "Trykker")]
        Trykker,

        /// <summary>
        /// EnumTulpenOne.
        /// </summary>
        [EnumMember(Value = "Tulpen One")]
        EnumTulpenOne,

        /// <summary>
        /// EnumTurretRoad.
        /// </summary>
        [EnumMember(Value = "Turret Road")]
        EnumTurretRoad,

        /// <summary>
        /// Ubuntu.
        /// </summary>
        [EnumMember(Value = "Ubuntu")]
        Ubuntu,

        /// <summary>
        /// EnumUbuntuCondensed.
        /// </summary>
        [EnumMember(Value = "Ubuntu Condensed")]
        EnumUbuntuCondensed,

        /// <summary>
        /// EnumUbuntuMono.
        /// </summary>
        [EnumMember(Value = "Ubuntu Mono")]
        EnumUbuntuMono,

        /// <summary>
        /// Ultra.
        /// </summary>
        [EnumMember(Value = "Ultra")]
        Ultra,

        /// <summary>
        /// EnumUncialAntiqua.
        /// </summary>
        [EnumMember(Value = "Uncial Antiqua")]
        EnumUncialAntiqua,

        /// <summary>
        /// Underdog.
        /// </summary>
        [EnumMember(Value = "Underdog")]
        Underdog,

        /// <summary>
        /// EnumUnicaOne.
        /// </summary>
        [EnumMember(Value = "Unica One")]
        EnumUnicaOne,

        /// <summary>
        /// UnifrakturCook.
        /// </summary>
        [EnumMember(Value = "UnifrakturCook")]
        UnifrakturCook,

        /// <summary>
        /// UnifrakturMaguntia.
        /// </summary>
        [EnumMember(Value = "UnifrakturMaguntia")]
        UnifrakturMaguntia,

        /// <summary>
        /// Unkempt.
        /// </summary>
        [EnumMember(Value = "Unkempt")]
        Unkempt,

        /// <summary>
        /// Unlock.
        /// </summary>
        [EnumMember(Value = "Unlock")]
        Unlock,

        /// <summary>
        /// Unna.
        /// </summary>
        [EnumMember(Value = "Unna")]
        Unna,

        /// <summary>
        /// VT323.
        /// </summary>
        [EnumMember(Value = "VT323")]
        VT323,

        /// <summary>
        /// EnumVampiroOne.
        /// </summary>
        [EnumMember(Value = "Vampiro One")]
        EnumVampiroOne,

        /// <summary>
        /// Varela.
        /// </summary>
        [EnumMember(Value = "Varela")]
        Varela,

        /// <summary>
        /// EnumVarelaRound.
        /// </summary>
        [EnumMember(Value = "Varela Round")]
        EnumVarelaRound,

        /// <summary>
        /// EnumVastShadow.
        /// </summary>
        [EnumMember(Value = "Vast Shadow")]
        EnumVastShadow,

        /// <summary>
        /// EnumVesperLibre.
        /// </summary>
        [EnumMember(Value = "Vesper Libre")]
        EnumVesperLibre,

        /// <summary>
        /// Vibes.
        /// </summary>
        [EnumMember(Value = "Vibes")]
        Vibes,

        /// <summary>
        /// Vibur.
        /// </summary>
        [EnumMember(Value = "Vibur")]
        Vibur,

        /// <summary>
        /// Vidaloka.
        /// </summary>
        [EnumMember(Value = "Vidaloka")]
        Vidaloka,

        /// <summary>
        /// Viga.
        /// </summary>
        [EnumMember(Value = "Viga")]
        Viga,

        /// <summary>
        /// Voces.
        /// </summary>
        [EnumMember(Value = "Voces")]
        Voces,

        /// <summary>
        /// Volkhov.
        /// </summary>
        [EnumMember(Value = "Volkhov")]
        Volkhov,

        /// <summary>
        /// Vollkorn.
        /// </summary>
        [EnumMember(Value = "Vollkorn")]
        Vollkorn,

        /// <summary>
        /// EnumVollkornSC.
        /// </summary>
        [EnumMember(Value = "Vollkorn SC")]
        EnumVollkornSC,

        /// <summary>
        /// Voltaire.
        /// </summary>
        [EnumMember(Value = "Voltaire")]
        Voltaire,

        /// <summary>
        /// EnumWaitingForTheSunrise.
        /// </summary>
        [EnumMember(Value = "Waiting for the Sunrise")]
        EnumWaitingForTheSunrise,

        /// <summary>
        /// Wallpoet.
        /// </summary>
        [EnumMember(Value = "Wallpoet")]
        Wallpoet,

        /// <summary>
        /// EnumWalterTurncoat.
        /// </summary>
        [EnumMember(Value = "Walter Turncoat")]
        EnumWalterTurncoat,

        /// <summary>
        /// Warnes.
        /// </summary>
        [EnumMember(Value = "Warnes")]
        Warnes,

        /// <summary>
        /// Wellfleet.
        /// </summary>
        [EnumMember(Value = "Wellfleet")]
        Wellfleet,

        /// <summary>
        /// EnumWendyOne.
        /// </summary>
        [EnumMember(Value = "Wendy One")]
        EnumWendyOne,

        /// <summary>
        /// EnumWireOne.
        /// </summary>
        [EnumMember(Value = "Wire One")]
        EnumWireOne,

        /// <summary>
        /// EnumWorkSans.
        /// </summary>
        [EnumMember(Value = "Work Sans")]
        EnumWorkSans,

        /// <summary>
        /// EnumYanoneKaffeesatz.
        /// </summary>
        [EnumMember(Value = "Yanone Kaffeesatz")]
        EnumYanoneKaffeesatz,

        /// <summary>
        /// Yantramanav.
        /// </summary>
        [EnumMember(Value = "Yantramanav")]
        Yantramanav,

        /// <summary>
        /// EnumYatraOne.
        /// </summary>
        [EnumMember(Value = "Yatra One")]
        EnumYatraOne,

        /// <summary>
        /// Yellowtail.
        /// </summary>
        [EnumMember(Value = "Yellowtail")]
        Yellowtail,

        /// <summary>
        /// EnumYeonSung.
        /// </summary>
        [EnumMember(Value = "Yeon Sung")]
        EnumYeonSung,

        /// <summary>
        /// EnumYesevaOne.
        /// </summary>
        [EnumMember(Value = "Yeseva One")]
        EnumYesevaOne,

        /// <summary>
        /// Yesteryear.
        /// </summary>
        [EnumMember(Value = "Yesteryear")]
        Yesteryear,

        /// <summary>
        /// Yrsa.
        /// </summary>
        [EnumMember(Value = "Yrsa")]
        Yrsa,

        /// <summary>
        /// EnumZCOOLKuaiLe.
        /// </summary>
        [EnumMember(Value = "ZCOOL KuaiLe")]
        EnumZCOOLKuaiLe,

        /// <summary>
        /// EnumZCOOLQingKeHuangYou.
        /// </summary>
        [EnumMember(Value = "ZCOOL QingKe HuangYou")]
        EnumZCOOLQingKeHuangYou,

        /// <summary>
        /// EnumZCOOLXiaoWei.
        /// </summary>
        [EnumMember(Value = "ZCOOL XiaoWei")]
        EnumZCOOLXiaoWei,

        /// <summary>
        /// Zeyada.
        /// </summary>
        [EnumMember(Value = "Zeyada")]
        Zeyada,

        /// <summary>
        /// EnumZhiMangXing.
        /// </summary>
        [EnumMember(Value = "Zhi Mang Xing")]
        EnumZhiMangXing,

        /// <summary>
        /// EnumZillaSlab.
        /// </summary>
        [EnumMember(Value = "Zilla Slab")]
        EnumZillaSlab,

        /// <summary>
        /// EnumZillaSlabHighlight.
        /// </summary>
        [EnumMember(Value = "Zilla Slab Highlight")]
        EnumZillaSlabHighlight
    }
}